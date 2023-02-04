using System;

namespace HometaskPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var store = new Store();
            int choice;
            do
            {
                Console.WriteLine("-------------- Rahat Market --------------");
                Console.WriteLine("----- Mehsullarin Axtaris Sistemi -----");
                Console.WriteLine("1. Drink Mehsul elave et");
                Console.WriteLine("2. Dairy product elave et");
                Console.WriteLine("3. butun mehsullara bax");
                Console.WriteLine("4. Verilmis no ile mehsula bax");
                Console.WriteLine("5. Drink productlarina bax");
                Console.WriteLine("6. Dairy productlarina bax");
                Console.WriteLine("7. ada gore axtaris et");
                Console.WriteLine("8. qiymet araligina gore axtaris et");
                Console.WriteLine("9. Siyahindan mehsul sil");
                Console.WriteLine("0. Menudan Cix");
                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        store.AddProduct();
                        break;
                    case 2:
                        store.AddDrinkProducts();
                        break;
                    case 3:
                        store.SeeAllProducts();
                        break;
                    case 4:
                        store.GetProductByNo();
                        break;
                    case 9:
                        store.RemoveProduct();
                        break;
                }
            }while(true);
        }

        private static void GetProductByNo()
        {
            throw new NotImplementedException();
        }
    }
}
