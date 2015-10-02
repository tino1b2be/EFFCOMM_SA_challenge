using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFFCOMM_SA_challenge.ControllersLayer
{
    /// <summary>
    /// Class for a Model-Security
    /// </summary>
    public class ModelSecurity
    {
        private int s_id;
        private int m_id;
        private int perc;
        private string modelName;
        private string secName;

        public ModelSecurity()
        {

        }

        public string securityName
        {
            get
            {
                return secName;
            }
            set
            {
                secName = value;
            }
        }

        public ModelSecurity(int modID, int secID, int perc)
        {
            this.s_id = secID;
            this.m_id = modID;
            this.perc = perc;
        }

        public ModelSecurity(ModelSecurity other)
        {
            this.modelID = other.modelID;
            this.securityID = other.securityID;
            this.securityName = other.securityName;
            this.percentage = other.percentage;
            this.modelName = other.modelName;
        }

        /// <summary>
        /// Getter/Setter for security name
        /// </summary>
        public int securityID
        {
            get
            {
                return s_id;
            }

            set
            {
                s_id = value;
            }
        }

        /// <summary>
        /// Getter/Setter for the Security ID
        /// </summary>
        public int modelID
        {
            get
            {
                return m_id;
            }
            set
            {
                m_id = value;
            }
        }

        /// <summary>
        /// Getter/Setter for the Security Price
        /// </summary>
        public int percentage
        {
            get
            {
                return perc;
            }
            set
            {
                perc = value;
            }
        }

        /// <summary>
        /// Overideen Equals method for this objce
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            var item = obj as ModelSecurity;

            if (item == null)
            {
                return false;
            }

            return (item.modelID == this.modelID && item.securityID == this.securityID);
        }

        public String ToString()
        {
            return "MID: " + m_id + " SID: " + s_id + " Perc: " + perc;
        }
    }
}
