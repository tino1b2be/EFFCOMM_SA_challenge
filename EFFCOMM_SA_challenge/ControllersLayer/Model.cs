using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFFCOMM_SA_challenge.ControllersLayer
{
    /// <summary>
    /// Class for a model
    /// </summary>
    class Model
    {
        private string name;
        private int id;
        private string descr;

        public Model()
        {

        }

        /// <summary>
        /// Copy constructor for Model
        /// </summary>
        /// <param name="otherModel">Model to be copied</param>
        public Model(Model otherModel)
        {
            this.id = otherModel.modelID;
            this.name = otherModel.modelName;
            this.descr = otherModel.modelDesc;
        }

        public Model(string name, string descr, int id)
        {
            this.name = name;
            this.descr = descr;
            this.id = id;
        }

        
        /// <summary>
        /// Getter/Setter for Model name
        /// </summary>
        public string modelName 
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        /// <summary>
        /// Getter/Setter for the Model ID
        /// </summary>
        public int modelID
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
        /// Getter/Setter for the Model Description
        /// </summary>
        public string modelDesc
        {
            get
            {
                return descr;
            }
            set
            {
                descr = value;
            }
        }

        public String ToString()
        {
            return id + " : " + name + " : " + descr;
        }
    }
}
