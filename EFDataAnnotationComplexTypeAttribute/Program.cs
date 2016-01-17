using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAnnotationComplexTypeAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            EFContext ctx = new EFContext();

            Customer c = new Customer();
            c.Name="Sachin Tendulkar";
            c.Contact.Email = "Email";
            c.Contact.Phone = "12345";
            ctx.Customers.Add(c);
            ctx.SaveChanges();

            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }
    }
}
