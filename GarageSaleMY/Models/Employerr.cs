using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarageSaleMY.Models
{
    public class Employerr
    {
        public string name { get; set; }
        public int staff_id { get; set; }
        public string password { get; set; }

        public string getName()
        {
            return name;
        }

        public int getStaffId()
        {
            return staff_id;
        }

        public string getPassword()
        {
            return password;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setStaffId(int staff_id)
        {
            this.staff_id = staff_id;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GarageSaleMY.Models
{
    public class Employerr
    {
    }
}