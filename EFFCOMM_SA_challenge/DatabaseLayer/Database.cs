using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.Windows.Forms;
using EFFCOMM_SA_challenge.Properties;

namespace EFFCOMM_SA_challenge.ModelsLayer
{   
    /// <summary>
    /// Class to use for database quieries.
    /// </summary>
    public class Database
    {
        private string strConn = Settings.Default.EFFCOMM_ChallengeConnectionString;
        protected SqlConnection cnMain; 

        /// <summary>
        /// Constructor that creates a Database connection
        /// </summary>
        public Database()
        {
            try
            {
                //Open a connection & create a new dataset object
                cnMain = new SqlConnection(strConn);
            }
            catch (SystemException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Error");
                return;
            }
        }

        /// <summary>
        /// Method to update the database with the SQL Command
        /// </summary>
        /// <param name="currentCommand">SQL Query/Command</param>
        /// <returns>True if update was successful else false</returns>
        protected bool UpdateDataSource(SqlCommand currentCommand)
        {
            bool success;
            try
            {
                //open the connection
                cnMain.Open();

                currentCommand.CommandType = CommandType.Text;
                currentCommand.ExecuteNonQuery();

                //close the connection
                cnMain.Close();
                success = true;
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
                cnMain.Close();
                success = false;
            }
            finally
            {
            }
            return success;
        }
    }
}
