namespace HometaskPolymorphism
{
    internal class StoreBase
    {
        public Product[] products;
        public int productCount;

        public Product GetProductByNo(int no)
        {
            for (int i = 0; i < productCount; i++)
            {
                if (products[i].No == no)
                {
                    return products[i];
                }
            }
            return null;
        }
    }

}