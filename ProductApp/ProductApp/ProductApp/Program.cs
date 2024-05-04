using ProductApp.Controllers;

namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductController controller = new ProductController();
            bool exit = false;
            do
            {
                Console.WriteLine("1.product elave et");
                Console.WriteLine("2.product sil");
                Console.WriteLine("3.product uzerinde deyisiklik et ");
                Console.WriteLine("4.product qaytar ");
                Console.WriteLine("5.butun product bax ");
                Console.WriteLine("0.Cixis");
                Console.WriteLine("Secim et:");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        controller.AddProduct();
                        break;
                    case "2":
                        controller.RemoveProduct();
                        break;
                    case "3":
                        controller.UpdateProduct();
                        break;
                    case "0":
                        exit = true;
                        break;
                    case "4":
                        controller.GetProduct();
                        break;
                    case "5":
                       controller.GetAllProduct();
                        break;
                    default:
                        Console.WriteLine("Secimin yalnisdir!");
                        break;
                }

            } while (!exit);

        }
    }
}
