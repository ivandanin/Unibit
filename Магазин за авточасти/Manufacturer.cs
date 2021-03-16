using System;
using System.Collections.Generic;
using System.Text;

namespace Магазин_за_авточасти
{
    public class Manufacturer
    {
        private string name;
        private string country;
        private string address;
        private string phoneNumber;
        private string fax;

        public Manufacturer(string name, string country, string address, string phoneNumber, string fax)
        {
            this.name = name;
            this.country = country;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.fax = fax;
        }
        public override string ToString() =>
            $"{this.name}<{this.country}, {this.address}, {this.phoneNumber}, {this.fax}>";
        
    }
}
