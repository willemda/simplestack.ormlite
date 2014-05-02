namespace SimpleStack.OrmLite.Tests.Shared
{
	public class ModelWithFieldsOfDifferentAndNullableTypesFactory
		: ModelFactoryBase<ModelWithFieldsOfDifferentAndNullableTypes>
	{
		public static ModelWithFieldsOfDifferentAndNullableTypesFactory Instance
			= new ModelWithFieldsOfDifferentAndNullableTypesFactory();

		public override void AssertIsEqual(
			ModelWithFieldsOfDifferentAndNullableTypes actual, ModelWithFieldsOfDifferentAndNullableTypes expected)
		{
			ModelWithFieldsOfDifferentAndNullableTypes.AssertIsEqual(actual, expected);
		}

		public override ModelWithFieldsOfDifferentAndNullableTypes CreateInstance(int i)
		{
			return ModelWithFieldsOfDifferentAndNullableTypes.CreateConstant(i);
		}
	}
}