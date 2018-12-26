using Builder_Example.Ingredients;
using Builder_Example.Product;

namespace Builder_Example
{
    class BuckwheatWithMeatBuilder
    {
        private readonly BuckwheatWithMeat _buckwheatWithMeat;

        public BuckwheatWithMeatBuilder()
        {
            _buckwheatWithMeat = new BuckwheatWithMeat();
        }

        public void AddSaltIngredient(Salt salt)
        {
            _buckwheatWithMeat.AddIngredients(salt);
        }

        public void AddMeatIngredient(Meat meat)
        {
            _buckwheatWithMeat.AddIngredients(meat);
        }

        public void AddBuckwheatIngredient(Buckwheat buckwheat)
        {
            _buckwheatWithMeat.AddIngredients(buckwheat);
        }

        public BuckwheatWithMeat GetProduct()
        {
            return _buckwheatWithMeat;
        }
    }
}
