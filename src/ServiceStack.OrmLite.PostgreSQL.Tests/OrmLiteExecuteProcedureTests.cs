using System.Collections.Generic;
using NUnit.Framework;
using SimpleStack.DataAnnotations;
using SimpleStack.OrmLite.Tests;

namespace SimpleStack.OrmLite.PostgreSQL.Tests
{
    [TestFixture]
    public class OrmLiteExecuteProcedureTests : OrmLiteTestBase
    {
        private const string Create = @"
            CREATE OR REPLACE FUNCTION f_service_stack(
                v_string_values CHARACTER VARYING[],
                v_integer_values INTEGER[]
            ) RETURNS BOOLEAN AS
            $BODY$
            BEGIN
                IF v_string_values[1] <> 'SimpleStack' THEN
                    RAISE EXCEPTION 'Unexpected value in string array[1] %', v_string_values[1];
                END IF;
                IF v_string_values[2] <> 'Thoughtfully Architected' THEN
                    RAISE EXCEPTION 'Unexpected value in string array[2] %', v_string_values[2];
                END IF;
                IF v_integer_values[1] <> 1 THEN
                    RAISE EXCEPTION 'Unexpected value in integer array[1] %', v_integer_values[1];
                END IF;
                IF v_integer_values[2] <> 2 THEN
                    RAISE EXCEPTION 'Unexpected value in integer array[2] %', v_integer_values[2];
                END IF;
                IF v_integer_values[3] <> 3 THEN
                    RAISE EXCEPTION 'Unexpected value in integer array[3] %', v_integer_values[3];
                END IF;
                RETURN TRUE;
            END;
            $BODY$
            LANGUAGE plpgsql VOLATILE COST 100;
            ";

        private const string Drop = "DROP FUNCTION f_service_stack(CHARACTER VARYING[], INTEGER[]);";

        [Alias("f_service_stack")]
        public class SimpleStackFunction
        {
            public string[] StringValues { get; set; }
            public int[] IntegerValues { get; set; }
        }

        [Test]
        public void Can_execute_stored_procedure_with_array_arguments()
        {
            using (var db = OpenDbConnection())
            {
                db.ExecuteSql(Create);

                db.ExecuteProcedure(new SimpleStackFunction
                                        {
                                            StringValues = new[] { "SimpleStack", "Thoughtfully Architected" },
                                            IntegerValues = new[] { 1, 2, 3 }
                                        });
                db.ExecuteSql(Drop);
            }
        }
    }
}
