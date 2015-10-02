using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFFCOMM_SA_challenge.ControllersLayer
{
    class DatabaseException : Exception
    {
        private string errorMessage = "An error has occured";

        public DatabaseException(string errorMessage)
            : base(errorMessage)
        {
            // TODO: Complete member initialization
            this.errorMessage = errorMessage;
        }

        public string error
        {
            get
            {
                return errorMessage;
            }
            set
            {
                errorMessage = value;
            }
        }
    }
}
