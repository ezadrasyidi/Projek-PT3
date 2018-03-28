using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarageSaleMY.Models
{
    public class List_Item
    {
        public string prodName { get; set; }
        public string prodId { get; set; }
        public int prodPrice { get; set; }

        public string getProdName()
        {
            return prodName;
        }

        public string getProdID()
        {
            return prodId;
        }

        public int getProdPrice()
        {
            return prodPrice;
        }

        public void setProdName(string prodName)
        {
            this.prodName = prodName;
        }

        public void setProdId(string prodId)
        {
            this.prodId = prodId;
        }

        public void setProdPrice(int prodPrice)
        {
            this.prodPrice = prodPrice;
        }
    }
}