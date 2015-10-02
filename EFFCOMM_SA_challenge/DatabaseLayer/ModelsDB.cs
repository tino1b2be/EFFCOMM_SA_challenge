using EFFCOMM_SA_challenge.ControllersLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFFCOMM_SA_challenge.ModelsLayer
{
    public class ModelsDB : Database
    {
        public ModelsDB()
            : base()    // constructor call to super class
        {
            ;
        }

        /// <summary>
        /// Method that returns a list off all model securities
        /// </summary>
        /// <returns>Null if there arent any</returns>
        internal Collection<ModelSecurity> getAllModSecurities()
        {
            SqlDataReader reader;
            SqlCommand command;
            Collection<ModelSecurity> dataOut = new Collection<ModelSecurity>();
            String selectString = "SELECT * FROM ModelSecurity";
            try
            {
                command = new SqlCommand(selectString, cnMain);
                cnMain.Open();                                  //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();               // read from table
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int modID = reader.GetInt32(0);
                        int secID = reader.GetInt32(1);
                        int perc = reader.GetInt32(2);
                        dataOut.Add(new ModelSecurity(modID, secID, perc));
                    }
                }
                reader.Close();  //close the reader 
                cnMain.Close();  //close the connection
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            if (dataOut.Count == 0)
                return null;
            else
                return dataOut;
        }

        /// <summary>
        /// Method that returns all Securities in the Database
        /// </summary>
        /// <returns>Null if there arent any</returns>
        internal Collection<Security> getAllSecurities()
        {
            SqlDataReader reader;
            SqlCommand command;
            Collection<Security> dataOut = new Collection<Security>();
            String selectString = "SELECT * FROM Securities";
            try
            {
                command = new SqlCommand(selectString, cnMain);
                cnMain.Open();                                  //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();               // read from table
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string name = reader.GetString(1).Trim();
                        int price = reader.GetInt32(2);
                        int id = reader.GetInt32(0);
                        dataOut.Add(new Security(name, id, price));
                    }
                }
                reader.Close();   //close the reader 
                cnMain.Close();  //close the connection
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            if (dataOut.Count == 0)
                return null;
            else
                return dataOut;
        }

        /// <summary>
        /// Method that returns all the Models in the DB
        /// </summary>
        /// <returns>Null if there aren't any</returns>
        internal Collection<Model> getAllModels()
        {
            SqlDataReader reader;
            SqlCommand command;
            Collection<Model> dataOut = new Collection<Model>();
            String selectString = "SELECT * FROM Models";
            try
            {
                command = new SqlCommand(selectString, cnMain);
                cnMain.Open();                                  //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();               // read from table
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string name = reader.GetString(1).Trim();
                        string descr = reader.GetString(2).Trim();
                        int id = reader.GetInt32(0);
                        dataOut.Add(new Model(name, descr, id));
                    }
                }
                reader.Close();   //close the reader 
                cnMain.Close();  //close the connection
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            if (dataOut.Count == 0)
                return null;
            else
                return dataOut;
        }

        /// <summary>
        /// Method to add a new model to the database
        /// </summary>
        /// <param name="model">Model to be added</param>
        internal void addModel(ControllersLayer.Model model)
        {
            string selectString = "INSERT into Models(ModelID, ModelName, ModelDescription)" + 
            "VALUES (" + model.modelID + ", '" + model.modelName + "', '" + model.modelDesc + "')";

            UpdateDataSource(new SqlCommand(selectString, cnMain));
        }

        /// <summary>
        /// Method to add a new Security to the DB
        /// </summary>
        /// <param name="sec"></param>
        internal void addSecurity(ControllersLayer.Security sec)
        {
            string selectString = "INSERT into Securities(SecurityID, SecurityName, SecurityPrice)" +
            "VALUES (" + sec.securityID + ", '" + sec.securityName + "', '" + sec.securityPrice + "')";

            UpdateDataSource(new SqlCommand(selectString, cnMain));
        }

        /// <summary>
        /// Method to add a Model Security to the DB
        /// </summary>
        /// <param name="modSec">ModSec object to add</param>
        internal void addModelSecurity(ModelSecurity modSec)
        {
            string selectString = "INSERT into ModelSecurity(ModelID, SecurityID, Percentage)" +
            "VALUES (" + modSec.modelID + ", '" + modSec.securityID + "', '" + modSec.percentage + "')";

            UpdateDataSource(new SqlCommand(selectString, cnMain));
        }

        /// <summary>
        /// Method to delete a models security from the DB
        /// </summary>
        /// <param name="modID">model ID</param>
        /// <param name="secID">security ID</param>
        internal void delModelSecurity(int modID, int secID)
        {
            string selectString = "DELETE FROM ModelSecurity " + 
                "WHERE ModelID = " + modID + " AND SecurityID = " + secID;

            UpdateDataSource(new SqlCommand(selectString, cnMain));
        }

        /// <summary>
        /// Method to update an existing model security
        /// </summary>
        /// <param name="modSec"></param>
        internal void updateModelSecurity(ModelSecurity modSec)
        {
            throw new NotImplementedException();
        }

        internal void updateModel(Model model)
        {
            throw new NotImplementedException();
        }

        internal void updateSecurity(Security sec)
        {
            throw new NotImplementedException();
        }

        internal void deleteModel(int modID)
        {
            throw new NotImplementedException();
        }

        internal void deleteSecurity(int secID)
        {
            throw new NotImplementedException();
        }

    }
}
