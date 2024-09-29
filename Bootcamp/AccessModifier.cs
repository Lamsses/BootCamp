using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp
{
    // Access Modifiers in C#
    // - public: Accessible from anywhere in the project or from other projects if referenced.
    // - private: Accessible only within the class it is declared. No other class, not even derived ones, can access it.
    // - internal: Accessible only within the same assembly (project). Not accessible from another project even if referenced.
    // - protected: Accessible within the class and by derived classes (even in other projects).
    // - protected internal: Accessible from the same assembly or any derived classes, even if they are in another assembly.
    // - private protected: Accessible only within the same class or derived classes, but only within the same assembly.

    // Public class: Can be accessed from anywhere in the project or referenced projects.
    public class PublicClass
    {
        // Public member: Can be accessed from anywhere
        public void PublicMethod()
        {
            Console.WriteLine("This is a public method.");
        }

        // Private member: Can only be accessed within this class.
        private void PrivateMethod()
        {
            Console.WriteLine("This is a private method.");
        }

        // Internal member: Can only be accessed from within the same assembly (project).
        internal void InternalMethod()
        {
            Console.WriteLine("This is an internal method.");
        }

        // Protected member: Can be accessed within this class or by derived classes.
        protected void ProtectedMethod()
        {
            Console.WriteLine("This is a protected method.");
        }

        // Protected internal member: Can be accessed from the same assembly or by derived classes, even from other assemblies.
        protected internal void ProtectedInternalMethod()
        {
            Console.WriteLine("This is a protected internal method.");
        }

        // Private protected member: Can be accessed only within this class or derived classes, but only within the same assembly.
        private protected void PrivateProtectedMethod()
        {
            Console.WriteLine("This is a private protected method.");
        }

        // Method to test the access within the same class
        public void TestAccess()
        {
            PublicMethod();           // Accessible
            PrivateMethod();          // Accessible (within the same class)
            InternalMethod();         // Accessible (within the same assembly)
            ProtectedMethod();        // Accessible (within the same class)
            ProtectedInternalMethod(); // Accessible (within the same assembly or derived)
            PrivateProtectedMethod();  // Accessible (within the same class)
        }
    }

    // Another class in the same assembly (project)
    internal class InternalClass
    {
        public void Test()
        {
            PublicClass publicClass = new PublicClass();
            publicClass.PublicMethod(); // Accessible (public)

            // The following lines would result in errors because the members are not accessible:
            // publicClass.PrivateMethod();       // Not accessible (private)
            // publicClass.InternalMethod();      // Accessible (internal, same assembly)
            // publicClass.ProtectedMethod();     // Not accessible (protected, not a derived class)
            // publicClass.PrivateProtectedMethod(); // Not accessible (private protected)
        }
    }

    // Derived class demonstrating access to protected and inherited members.
    public class DerivedClass : PublicClass
    {
        public void Test()
        {
            PublicMethod();            // Accessible (public)
                                       // PrivateMethod();        // Not accessible (private)
            InternalMethod();          // Accessible (internal, same assembly)
            ProtectedMethod();         // Accessible (protected, from derived class)
            ProtectedInternalMethod(); // Accessible (protected internal, derived or same assembly)
                                       // PrivateProtectedMethod(); // Not accessible (private protected from another class in the same assembly)
        }
    }

    // Another derived class in the same assembly demonstrating private protected access
    internal class DerivedInternalClass : PublicClass
    {
        public void Test()
        {
            PublicMethod();            // Accessible (public)
                                       // PrivateMethod();        // Not accessible (private)
            InternalMethod();          // Accessible (internal, same assembly)
            ProtectedMethod();         // Accessible (protected)
            ProtectedInternalMethod(); // Accessible (protected internal, same assembly)
            PrivateProtectedMethod();  // Accessible (private protected, from derived class in the same assembly)
        }
    }
}
