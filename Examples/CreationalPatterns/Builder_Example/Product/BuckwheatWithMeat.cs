using System.Collections.Generic;

namespace Builder_Example.Product
{
    class BuckwheatWithMeat
    {
        public List<object> Ingredients { get; set; }

        public void AddIngredients(object ingredient)
        {
            Ingredients.Add(ingredient);
        }
    }
}
