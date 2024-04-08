using DesignPatterns.FactoryMethod.ConcreteCreator;
using DesignPatterns.FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    //Factory Method is a creational design patternand it is one of the most frequently used design pattern in real life
    //Factory Method Design Pattern Defines an interface for creating an object but lets the subclasses decide which class to instantiate.
    //The Factory method lets a class defer instantiation to subclasses.
    //The Factory Method Design Pattern provides an interface for creating objects in a superclass 
    //but allows subclasses to alter the type of objects that will be created.
    //In the factory method design pattern, we will create an abstract class as the Factory class, which will create and return the product instance, 
    //but it will let the subclasses decide which class to instantiate. 

    public class FactoryClient
    {
        public void FactorClientWrapper()
        {
            // The client code works with an instance of a concrete creator
            // The CreateProduct will return the actual product instance via the product interface
            //PlatinumFactory CreateProduct method will return an instance of Platinum Product via the CreditCard interface
            ICreditCard creditCard = new PlatinumFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("Card Type : " + creditCard.GetCardType());
                Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.WriteLine("--------------");
            //MoneyBackFactory CreateProduct method will return an instance of Platinum Product via the CreditCard interface
            creditCard = new MoneyBackFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("Card Type : " + creditCard.GetCardType());
                Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.WriteLine("--------------");
            //TitaniumFactory CreateProduct method will return an instance of Platinum Product via the CreditCard interface
            creditCard = new TitaniumFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("Card Type : " + creditCard.GetCardType());
                Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.WriteLine("--------------");
            new PlatinumFactory().Test();
            Console.WriteLine(PlatinumFactory.StaticTest());
            Console.ReadLine();
        }
    }
}
