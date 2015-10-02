using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFFCOMM_SA_challenge.ControllersLayer
{
    /// <summary>
    /// Class for a Security
    /// </summary>
    public class Security
    {
        private string sname;
        private int id;
        private int price;

        public Security()
        {

        }

        public Security(string name, int id2, int price2)
        {
            this.sname = name;
            this.id = id2;
            this.price = price2;
        }
        
        /// <summary>
        /// Getter/Setter for security name
        /// </summary>
        public string securityName 
        {
            get
            {
                return sname;
            }

            set
            {
                sname = value;
            }
        }

        /// <summary>
        /// Getter/Setter for the Security ID
        /// </summary>
        public int securityID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        /// <summary>
        /// Getter/Setter for the Security Price
        /// </summary>
        public int securityPrice
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public String ToString()
        {
            return id + " : " + sname + " : " + price;
        }
    }
}
