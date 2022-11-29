using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    /*
    internal class Shapes //This is a class
    {
        public int NoOfSides;//this is an object

        public Shapes(int _noOfSides)
        {
            NoOfSides = _noOfSides;
        }
    }
    */

    internal class Product
    {
                   //Guid = Global Unique Identifier.  Generates a long number
        public Guid ID;
        public string Name;
        public float Price;

        //-----Consturctor Overloading-----
        public Product()// Default Constructor - sets all parameters too defaults
        {
            ID = Guid.NewGuid();
            Name = String.Empty;
            Price = 0.00f;
        }

        public Product(string _name, float _price)// Constructor
        {
            ID = Guid.NewGuid();//generates a new Guid int
            Name = _name;
            Price = _price;
        }

        public Product(string _name)//only takes in name
        {
            ID = Guid.NewGuid();
            Name = _name;
            Price = 0.00f;
        }


        public override string ToString()
        {
            return $"ID: { ID }\nName: { Name }\nPrice: £{ Price }\n";
        }
    }




    internal class Animals
    {
        public string AnimalName;
        public string AnimalKingdom;
        public string CarOmnHerb;
        public bool Endangered;

        public Animals()
        {
            AnimalName = String.Empty;
            AnimalKingdom = String.Empty;
            CarOmnHerb = String.Empty;
            Endangered = false;
        }

        public Animals(string _animalName, string _animalKingdom, string _carOmnHerb, bool _endangered)
        {
            AnimalName = _animalName;
            AnimalKingdom = _animalKingdom;
            CarOmnHerb = _carOmnHerb;
            Endangered = _endangered;
        }
        public Animals(string _animalName, string _animalKingdom, bool _endangered)
        {
            AnimalName = _animalName;
            AnimalKingdom = _animalKingdom;
            CarOmnHerb = String.Empty;
            Endangered = _endangered;
        }

        public override string ToString()
        {
            return $"Name: { AnimalName }\nKingdom: { AnimalKingdom }\nDiet: { CarOmnHerb }\nendangered: £{ Endangered }\n";
        }
    }


    class Customers
    {
        public string CustomerName;
        public string CustomerEmail;
        public string CustomerPhone;

        public Customers()
        {
            CustomerName = string.Empty;
            CustomerEmail = string.Empty;
            CustomerPhone = string.Empty;
        }
        public Customers(string _customerName, string _customerEmail, string _customerPhone)
        {
            CustomerName = _customerName;
            CustomerEmail = _customerEmail;
            CustomerPhone = _customerPhone;
        }
        public Customers(string _customerName, string _customerEmail)
        {
            CustomerName = _customerName;
            CustomerEmail = _customerEmail;
            CustomerPhone = String.Empty;
        }

        public override string ToString()
        {
            return $"Name: {CustomerName }\nEmail: { CustomerEmail }\nPhone: { CustomerPhone }\n";
        }
    }

}
