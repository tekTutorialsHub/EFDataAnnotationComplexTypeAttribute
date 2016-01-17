using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDataAnnotationComplexTypeAttribute
{

    public class Customer
    {

        public Customer()
        {
            Contact = new ContactInfo();
        }
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public ContactInfo Contact { get; set; }
    }


    public class Employee

    {

        public Employee()
        {
            EmployeeContact = new ContactInfo();
        }
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public ContactInfo EmployeeContact { get; set; } 

    }


    [ComplexType]
    public class ContactInfo
    {
        public string Email { get; set; }
        public string Phone { get; set; }
    }


}
