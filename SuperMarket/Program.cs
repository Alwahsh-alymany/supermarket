using System;

namespace SuperMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            CashRegister register1 = new CashRegister();
            string input = "";


            Console.WriteLine(@"
                     
{0}                   █     █░▓█████  ██▓     ▄████▄   ▒█████   ███▄ ▄███▓▓█████    ▄▄▄█████▓ ▒█████  
{0}                  ▓█░ █ ░█░▓█   ▀ ▓██▒    ▒██▀ ▀█  ▒██▒  ██▒▓██▒▀█▀ ██▒▓█   ▀    ▓  ██▒ ▓▒▒██▒  ██▒
{0}                  ▒█░ █ ░█ ▒███   ▒██░    ▒▓█    ▄ ▒██░  ██▒▓██    ▓██░▒███      ▒ ▓██░ ▒░▒██░  ██▒
{0}                  ░█░ █ ░█ ▒▓█  ▄ ▒██░    ▒▓▓▄ ▄██▒▒██   ██░▒██    ▒██ ▒▓█  ▄    ░ ▓██▓ ░ ▒██   ██░
{0}                  ░░██▒██▓ ░▒████▒░██████▒▒ ▓███▀ ░░ ████▓▒░▒██▒   ░██▒░▒████▒     ▒██▒ ░ ░ ████▓▒░
{0}                  ░ ▓░▒ ▒  ░░ ▒░ ░░ ▒░▓  ░░ ░▒ ▒  ░░ ▒░▒░▒░ ░ ▒░   ░  ░░░ ▒░ ░     ▒ ░░   ░ ▒░▒░▒░ 
{0}                    ▒ ░ ░   ░ ░  ░░ ░ ▒  ░  ░  ▒     ░ ▒ ▒░ ░  ░      ░ ░ ░  ░       ░      ░ ▒ ▒░ 
{0}                    ░   ░     ░     ░ ░   ░        ░ ░ ░ ▒  ░      ░      ░        ░      ░ ░ ░ ▒  
", " ");        
                

            Console.Write("\t\t============================= MY PROJECT ALOAHSH SUPERMARCET============================");
            Console.WriteLine("\t\t\t----------------------------------| Mohamed  ALomari |----------------------------------");
        Console.WriteLine("\t\t***************************************************************************************** \n");






            do
            {
                  Console.WriteLine("\t\t\t\tPlease enter product name:                             ");
                 string name = Console.ReadLine();
                 
                 Console.WriteLine("\t\t\t\tPlease enter product price (or price/kg if weighted):   ");
                 decimal price = decimal.Parse(Console.ReadLine());
                 
                 Console.WriteLine("\t\t\t\tIf weighted please enter weight, else type 0:           ");
                 decimal weight = decimal.Parse(Console.ReadLine());
                 
                 Product product = weight > 0 ? new Product(name, price, weight) : new Product(name, price);
                 
                 register1.Scan(product);
                 
                  Console.WriteLine("\t\t\t\tIf you'd like to add another product, type 'add'. Else, type 'checkout':  ");
               input = Console.ReadLine();
                while (input != "add" && input != "checkout")
                {
                    Console.WriteLine("\t\tPlease enter valid input:                                                    ");
                    input = Console.ReadLine();
                }
                Console.WriteLine("\n\n==============================================================================================================================");
            }
            while (input == "add");

            register1.Receipt();
            Console.Write("\t\t\t\t");
            Console.ReadKey();
        }
    }
}
