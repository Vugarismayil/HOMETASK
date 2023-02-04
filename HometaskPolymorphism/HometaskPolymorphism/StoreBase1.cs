namespace HometaskPolymorphism
{
    internal class StoreBase1
    {

        public Product[] GetDrinkProducts()
        {
            int drinkCount = 0;
            for (int i = 0; i < productCount; i++)
            {
                if (products[i] is Drink)
                {
                    drinkCount++;
                }
            }




            Drink[] drinks = new Drink[drinkCount];
            int j = 0;
            for (int i = 0; i < productCount; i++)
            {
                if (products[i] is Drink)
                {
                    drinks[j] = (Drink)products[i];
                    j++;
                }
            }




        }
    }
}