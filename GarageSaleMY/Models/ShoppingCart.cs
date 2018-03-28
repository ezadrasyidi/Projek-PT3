using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarageSaleMY.Models
{
    public class ShoppingCart
    {
        public string prodName { get; set; }
        public int prodQuantity { get; set; }
        public int prodPrice { get; set; }

        public string getProdName()
        {
            return prodName;
        }

        public int getProdQuantity()
        {
            return prodQuantity;
        }

        public int getProdPrice()
        {
            return prodPrice;
        }

        public void setProdName(string prodName)
        {
            this.prodName = prodName;
        }

        public void setProdQuantity(int prodQuantity)
        {
            this.prodQuantity = prodQuantity;
        }

        public void setProdPrice(int prodPrice)
        {
            this.prodPrice = prodPrice;
        }
    }
}
