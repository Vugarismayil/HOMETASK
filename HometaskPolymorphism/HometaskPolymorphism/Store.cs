using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace HometaskPolymorphism
{
    internal class Store : StoreBase1
    {
        public int No;
        private Product[] products;
        private int productCount;
        public int DairyProductCountLimit { get; set; }
        public decimal AlcoholPercentLimit { get; set; }

        public Store()
        {
            products = new Product[10];
            productCount = 0;
        }

        public void AddProduct(Product product)
        {
            products[productCount] = product;
            productCount++;
        }

        public bool HasProductByNo(int no)
        {
            for (int i = 0; i < productCount; i++)
            {
                if (products[i].No == no)
                {
                    return true;
                }
            }

            return false;
        }

        public Product GetProductByNo(int no)
        {
            for (int i = 0; i < productCount ; i++)
            {
                if (products[i].No == no)
                {
                    return products[i];
                }
            }
            



        }

        public Product[] DairyProducts
        {
            get
            {
                return DairyProducts;
            }
            set
            {
                int dairyCount = 0;
                for (int i = 0; i < productCount; i++)
                {
                    if (products[i] is Dairy)
                    {
                        dairyCount++;
                    }
                }

                Dairy[] dr = new Dairy[dairyCount];
                int j = 0;
                for (int i = 0; i < productCount; i++)
                {
                    if (products[i] is Dairy)
                    {
                        dr[j] = (Dairy)products[i];
                        j++;
                    }
                }

                Dairy[] dr1 = dr;
            }
        }

        public void RemoveProduct(int no)
        {
            int index = -1;
            for (int i = 0; i < productCount; i++)
            {
                if (products[i].No == no)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                for (int i = index; i < productCount - 1; i++)
                {
                    products[i] = products[i + 1];
                }
                productCount--;
            }
        }

        internal void RemoveProduct()
        {
            throw new NotImplementedException();
        }

        internal void AddDrinkProducts()
        {
            throw new NotImplementedException();
        }

        internal void SeeAllProducts()
        {
            throw new NotImplementedException();
        }

        internal void GetProductByNo()
        {
            throw new NotImplementedException();
        }

        internal void AddProduct()
        {
            throw new NotImplementedException();
        }
    }
}
