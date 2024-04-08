using DesignPatterns.FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.AbstractCreator
{
    // The CreditCardFactory Creator class declares the factory method 
    // that is going to return an object of a Product class. 
    // The CreditCardFactory subclasses usually provide the implementation of the MakeProduct method.

    public abstract class CreditCardFactory
    {
        public CreditCardFactory()
        {
            Console.WriteLine("Inside Abstract Class 'CreditCardFactory' Default Constructor");
        }
        static CreditCardFactory()
        {
            Console.WriteLine("Inside Abstract Class 'CreditCardFactory' static Constructor");
        }
        protected abstract ICreditCard MakeProduct();
        // Also note that The Creator's primary responsibility is not creating products. 
        // Usually, it contains some core business logic that relies on Product objects, returned by the factory method. 
        public ICreditCard CreateProduct()
        {
            //Call the MakeProduct which will create and return the appropriate object 
            ICreditCard creditCard = MakeProduct();

            //Return the Object to the Client

            return creditCard;
        }

        public void Test()
        {
            Console.WriteLine("Inside Abstract Factory Class");
        }

        public static string StaticTest()
        {
            return "Inside Static Method of Factory Class";
        }
    }
}
