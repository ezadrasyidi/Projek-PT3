using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarageSaleMY.Models
{
    public class Customer
    {
        public string name { get; set; }
        public string address { get; set; }
        public int tel_num { get; set; }

        public string getName()
        {
            return name;
        }

        public string getAddress()
        {
            return address;
        }

        public int getTelNum()
        {
            return tel_num;
        }


        public void setName(string name)
        {
            this.name = name;
        }

        public void setAddress(string address)
        {
            this.address = address;
        }

        public void setTelNum(int tel_num)
        {
            this.tel_num = tel_num;
        }


    }
}
