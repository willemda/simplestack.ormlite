namespace SimpleStack.OrmLite.Tests.Shared
{
	public class ModelWithFieldsOfDifferentTypesFactory
		: ModelFactoryBase<ModelWithFieldsOfDifferentTypes>
	{
		public static ModelWithFieldsOfDifferentTypesFactory Instance
			= new ModelWithFieldsOfDifferentTypesFactory();

		public override void AssertIsEqual(
			ModelWithFieldsOfDifferentTypes actual, ModelWithFieldsOfDifferentTypes expected)
		{
			ModelWithFieldsOfDifferentTypes.AssertIsEqual(actual, expected);
		}

		public override ModelWithFieldsOfDifferentTypes CreateInstance(int i)
		{
			return ModelWithFieldsOfDifferentTypes.CreateConstant(i);
		}
	}
}