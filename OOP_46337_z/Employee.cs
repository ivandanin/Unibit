using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_46337_z
{
    public class Employee
    {
        private string firstName;
        private string lastName;
        private int age;
        private string personalID;
        private decimal interest;
        private string client;
        

        public Employee(string firstName, string lastName, int age, string personalID, string client)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.personalID = personalID;
            this.client = client;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName 
        {
            get;
            set;
        }
      

        public int Age
        {
            get { return age; }
            set
            {
                if (age <= 0)
                {
                    throw new Exception();
                } 
                age = value;
            }
        }

        public string PersonalID
        {
            get;
            set;
        }

        public decimal Interest
        {
            get;
            set;
        }
        public string Client
        {
            get { return client; }
            set
            {
                if (client.Equals("client"))
                {
                    interest = (decimal) ClientInterest.CLIENT;               
                } else
                {
                    interest = (decimal)ClientInterest.NONCLIENT;
                }
            } 
        }

       public void statusCheck()
        {
            if (age <= 25)
            { if(client.Equals("client"))
                {
                Console.WriteLine(age + "г., студент, клиент");

                } else
                {
                Console.WriteLine(age + "г., студент, не е клиент");

                }

            } else if (age > 25 && age <= 65)
            {if(client.Equals("client"))
                {
                Console.WriteLine(age + "г., възрастен, клиент");

                } else
                {
                Console.WriteLine(age + "г., възрастен, не е клиент");

                }
            } else
            {
                if (client.Equals("client"))
                {
                Console.WriteLine(age + "г., пенсионер, клиент");

                } else
                {
                Console.WriteLine(age + "г., пенсионер, не е клиент");

                }
            }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format(firstName + " " + lastName + " "
                + age + " " + personalID + " " + client);
        }
    }
}
