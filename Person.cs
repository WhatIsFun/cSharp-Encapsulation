using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_PropertiesAndEncapsulation
{
    internal class Person
    {
        // Declare private fields for name, age and address
        private string name { get; set; }
        private int age { get; set; }
        private string address { get; set; }

        // Provide public methods to set and get the values of these fields

        // Set the name of the person
         
        public Person(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }
        public void SetName(string newName)
        {
            name = newName;
        }

        // Get the name of the person
        public string GetName()
        {
            return name;
        }

        // Set the age of the person
        public void SetAge(int newAge)
        {
            age = newAge;
        }

        // Get the age of the person
        public int GetAge()
        {
            return age;
        }

        // Set the address of the person
        public void SetAddress(string newAddress)
        {
            address = newAddress;
        }

        // Get the address of the person
        public string GetAddress()
        {
            return address;
        }
    }
}

