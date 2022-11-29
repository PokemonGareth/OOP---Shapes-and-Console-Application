using System;

namespace Shapes
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            /*
                                          //"new" is an instance
            Shapes square = new Shapes(4);//this is an object
            Shapes triangle = new Shapes(3);
            Shapes circle = new Shapes(1);

            Console.WriteLine($"Squares have { square.NoOfSides } Sides.");
            Console.WriteLine($"Triangles have { triangle.NoOfSides } Sides.");
            Console.WriteLine($"Circles have { circle.NoOfSides } Sides.");
            */

            Product Banana = new Product( "Banana", 1.9f);
            Product Chocolate = new Product("Chocolate", 3f);
            Product TV = new Product();// uses default constructor
            Product House = new Product("House");// uses constructor that only takes in name
            /*
            Console.WriteLine(Banana);
            Console.WriteLine(Chocolate);
            */

            //"Product" is now a type and therefore we can use it in a list
            List<Product> list = new List<Product>();
            list.Add(Banana);
            list.Add(Chocolate);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

            Console.ForegroundColor = ConsoleColor.Green;//changes text color
            //Console.BackgroundColor = ConsoleColor.Black;//changes Background colour

            Animals Hippo = new Animals("Hippo", "Mammal", "Carnivoure", false );
            Animals girrafe = new Animals("Girrafe", "Mammal", true);

            List<Animals> Animals = new List<Animals>();
            Animals.Add(Hippo);
            Animals.Add(girrafe);

            foreach (Animals a in Animals)
            {
                Console.WriteLine(a);
            }

            Console.ForegroundColor = ConsoleColor.Red;

            Customers customer1 = new Customers("Gareth", "searlegareth2004@gmail.com", "07957301514");
            Customers customer2 = new Customers("Thomas", "searlethomas20071@gmail.com");

            List<Customers> customerlist = new List<Customers>();
            customerlist.Add(customer1);
            customerlist.Add(customer2);

            foreach (Customers c in customerlist)
            {
                Console.WriteLine(c);
            }
        }
    }
}