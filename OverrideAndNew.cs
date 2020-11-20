using System;

namespace InheritanceExample
{
    class BaseClass
    {
        public virtual void Method1()
        {
            Console.WriteLine("Base - Method1");
        }

        public virtual void Method2()
        {
            Console.WriteLine("Base - Method2");
        }
    }

    class DerivedClass : BaseClass
    {
        public override void Method1()
        {
            Console.WriteLine("Derived - Method1");
        }

        public new void Method2()
        {
            Console.WriteLine("Derived - Method2");
        }
    }

    class OverrideAndNew
    {
        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass(); //bc is of type BaseClass, and its value is of type BaseClass.
            DerivedClass dc = new DerivedClass(); //dc is of type DerivedClass, and its value is of type DerivedClass.
            BaseClass bcdc = new DerivedClass(); //bcdc is of type BaseClass, and its value is of type DerivedClass.

            // The following two calls do what you would expect. They call  
            // the methods that are defined in BaseClass.  
            bc.Method1();
            bc.Method2();
            // Output:  
            // Base - Method1  
            // Base - Method2  

            // The following two calls do what you would expect. They call  
            // the methods that are defined in DerivedClass.  
            dc.Method1();
            dc.Method2();
            // Output:  
            // Derived - Method1  
            // Derived - Method2  

            // The following two calls produce different results, depending
            // on whether override (Method1) or new (Method2) is used.  
            bcdc.Method1();
            bcdc.Method2();
            // Output:  
            // Derived - Method1  
            // Base - Method2  

            Console.ReadLine();
        }
    }

    
}
