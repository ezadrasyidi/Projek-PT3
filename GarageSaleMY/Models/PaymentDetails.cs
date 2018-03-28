using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarageSaleMY.Models
{
    public class Payment_Details
    {
        public string nameCard { get; set; }
        public string cardNo { get; set; }
        public string issuedBank { get; set; }
        public string cvv { get; set; }
        public string expiryDate { get; set; }

        public string getNameCard()
        {
            return nameCard;
        }

        public string getCardNo()
        {
            return cardNo;
        }

        public string getIssuedBank()
        {
            return issuedBank;
        }

        public string getCvv()
        {
            return cvv;
        }

        public string getExpiryDate()
        {
            return expiryDate;
        }

        public void setNameCard(string nameCard)
        {
            this.nameCard = nameCard;
        }

        public void setIssuedBank(string issuedBank)
        {
            this.issuedBank = issuedBank;
        }

        public void setCardNo(string cardNo)
        {
            this.cardNo = cardNo;
        }

        public void setCvv(string cvv)
        {
            this.cvv = cvv;
        }

        public void setExpiryDate(string expiryDate)
        {
            this.expiryDate = expiryDate;
        }
    }
}
