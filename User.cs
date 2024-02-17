using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSUIR_Lab_7_Tasks_3
{
    public class User : IComparable<User>
    {
        public string name;
        public string surname;
        private int age;
        public int id;
        public int Age { get { return age; } set { if (value >= 0) age = value; else throw new Exception(); } }
        public User() 
        { 
            name = string.Empty;
            surname = string.Empty;
            age = 0;
            id = 0;
        }
        public User(string name, string surname, int age, int id) :this()
        {
            this.name = name;
            this.surname = surname;
            Age = age;
            this.id = id;
        }

        public override string ToString()
        {
            return $"User: Name: {name}. Surname: {surname}. Age: {Age}. Id: {id}.";
        }
        public void Print() => Console.WriteLine(this);

        public int CompareTo(User? other)
        {
            if (other is not null && other is User)
            {
                return name.CompareTo(other.name);
            }
            else throw new ArgumentException("Incorrect argument."); 
        }
    }
}
