using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6._3
{
    enum ProblemArea
    {
        Internet,
        Phone,
        Cable,
        Other
    }
    internal class Customer
    {
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public ProblemArea Issue { get; set; }

        public Customer(string name, int number, ProblemArea issue)
        {
            Name = name;
            PhoneNumber = number;
            Issue = issue;
        }
    }
}
