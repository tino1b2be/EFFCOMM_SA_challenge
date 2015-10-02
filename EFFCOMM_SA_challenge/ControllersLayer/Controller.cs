
using EFFCOMM_SA_challenge.ModelsLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFFCOMM_SA_challenge.ControllersLayer
{
    public class Controller
    {
        ModelsDB database;                  // Databse object for the controller
        // the following will be updates after every insert/delete/alter
        Collection<Model> models;           // collection of all the models in the DB
        Collection<Security> securities;    // collection of all securites in the DB
        Collection<ModelSecurity> modSecs;   // collection of all ModelSecurity objects in the database

        public Controller()
        {
            database = new ModelsDB();
            updateCollections();
        }

        /// <summary>
        /// Method to update the models, securities and modSec collections
        /// Method is called after every change that takes place in the DB
        /// </summary> 
        private void updateCollections()
        {
            models = database.getAllModels();
            securities = database.getAllSecurities();
            modSecs = database.getAllModSecurities();
            // set the names of the securities in ModelSecuties
            foreach (ModelSecurity secMod in modSecs)
            {
                string secName = "Unidentified Security Name";
                foreach (Security sec in securities) // loop to retrieve the name
                {
                    if (secMod.securityID == sec.securityID)
                    {
                        secName = sec.securityName;
                        break;
                    }
                }
                secMod.securityName = secName;
            }   
        }
       
        /// <summary>
        /// Method that adds a new model to the database.
        /// This method throws a databse exception when adding a model has failed
        /// </summary>
        /// <param name="model">model object to be added</param>
        internal void addModel(Model model)
        {

            // check if the model is already in the database
            foreach (Model mod in models)
            {
                if (mod.modelID == model.modelID)
                    throw new DatabaseException("A Model with that ID alredy exits!");
            }
            try
            {
                database.addModel(model);
                updateCollections();        // update the collections after a successful addition
            }
            catch (DatabaseException err)
            {
                throw new DatabaseException(err.error);
            }
            
        }

        /// <summary>
        /// Method to add a new Security to the databse
        /// </summary>
        /// <param name="sec">Security to be added</param>
        internal void addSecurity(Security sec)
        {
            // check if the model is already in the database
            foreach (Security other in securities)
            {
                if (sec.securityID == other.securityID)
                    throw new DatabaseException("A Security with that ID alredy exits!");
            }
            try
            {
                database.addSecurity(sec);
                updateCollections();        // update the collections after a successful addition
            }
            catch (DatabaseException err)
            {
                throw new DatabaseException(err.error);
            }
        }

        /// <summary>
        /// Method to return all the Securities in the DB
        /// </summary>
        /// <returns></returns>
        internal Collection<Security> getAllSecurities()
        {
            return securities; // TODO Return copy
        }

        /// <summary>
        /// Method to retrieve all the Models in a DB
        /// </summary>
        /// <returns>All Models</returns>
        internal Collection<Model> getAllModels()
        {
            return models; // TODO return copy
        }

        /// <summary>
        /// Method to return all the securites in the DB for a given model
        /// </summary>
        /// <param name="p">Models ID </param>
        /// <returns></returns>
        internal Collection<ModelSecurity> getSecurities(int modelID)
        {
            Collection<ModelSecurity> data = new Collection<ModelSecurity>();
            foreach (ModelSecurity m in modSecs)
            {
                if (modelID == m.modelID)
                    data.Add(new ModelSecurity(m));
            }
            return data;
        }

        /// <summary>
        /// Method to add a new security to a model
        /// </summary>
        /// <param name="modSec">model security object</param>
        internal void addSecToModel(ModelSecurity modSec)
        {
            try
            {
                // first check if the percentage being added does not exceed 100% for that model
                if (percIsValid(modSec))
                {
                    database.addModelSecurity(modSec);
                    updateCollections();
                }
                else
                    throw new DatabaseException("The percentages for this model exceed 100%, please check the values again.");
            }
            catch (DatabaseException err)
            {
                throw new DatabaseException(err.error);
            }
        }

        /// <summary>
        /// Method to delete a model security from the DB
        /// </summary>
        /// <param name="modID"></param>
        /// <param name="secID"></param>
        internal void delSecFromModel(int modID, int secID)
        {
            // check if it exists
            if (modSecExists(modID, secID)){
                try
                {
                    database.delModelSecurity(modID, secID);
                    updateCollections();
                }
                catch (DatabaseException err)
                {
                    throw new DatabaseException(err.error);
                }
            }
            else
            {
                throw new DatabaseException("Security does not exist");
            }
            
        }

        /// <summary>
        /// Methdo to update a model security in the DB
        /// </summary>
        /// <param name="modSec"></param>
        internal void updateSecInModel(ModelSecurity modSec)
        {
            try
            {
                database.updateModelSecurity(modSec);
                updateCollections();
            }
            catch (DatabaseException err)
            {
                throw new DatabaseException(err.error);
            }
        }

        /// <summary>
        /// Method to update a Model inside the DB
        /// </summary>
        /// <param name="model">model to update</param>
        internal void updateModel(Model model)
        {
            try
            {
                database.updateModel(model);
                updateCollections();
            }
            catch (DatabaseException err)
            {
                throw new DatabaseException(err.error);
            }
        }

        /// <summary>
        /// Method to update a security in the DB
        /// </summary>
        /// <param name="sec">security bject to update</param>
        internal void updateSecurity(Security sec)
        {
            try
            {
                database.updateSecurity(sec);
                updateCollections();
            }
            catch (DatabaseException err)
            {
                throw new DatabaseException(err.error);
            }
        }

        /// <summary>
        /// Method to delete a model from the DB
        /// </summary>
        /// <param name="p">Model ID</param>
        internal void delModel(int modID)
        {
            try
            {
                database.deleteModel(modID);
                updateCollections();
            }
            catch (DatabaseException err)
            {
                throw new DatabaseException(err.error);
            }
        }

        /// <summary>
        /// Method to delete a security from the database
        /// </summary>
        /// <param name="p">Security ID</param>
        internal void delSec(int secID)
        {
            try
            {
                database.deleteSecurity(secID);
                updateCollections();
            }
            catch (DatabaseException err)
            {
                throw new DatabaseException(err.error);
            }
        }

        /// <summary>
        /// Method to return a model object
        /// </summary>
        /// <param name="modelID"> Model ID for requested model</param>
        /// <returns>Model object for given ID</returns>
        internal Model getModel(int modelID)
        {
            foreach (Model model in models)
            {
                if (model.modelID == modelID)
                    return new Model(model);
            }
            throw new DatabaseException("Model not found.");
        }

        /// <summary>
        /// Method to check if a secusity exists in a model
        /// </summary>
        /// <param name="modID"></param>
        /// <param name="secID"></param>
        /// <returns></returns>
        private bool modSecExists(int modID, int secID)
        {
            foreach (ModelSecurity ms in modSecs)
            {
                if (ms.securityID == secID && modID == ms.modelID)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Method to check if a percentage is valid
        /// Also checks if the security does not already exist in the model
        /// </summary>
        /// <param name="otherModSec"></param>
        /// <returns></returns>
        private bool percIsValid(ModelSecurity otherModSec)
        {
            if (otherModSec.percentage > 100)
                return false;

            int totalPerc = 0;
            foreach (ModelSecurity modsecDB in modSecs) 
            {
                if (modsecDB.modelID == otherModSec.modelID)
                {
                    if (modsecDB.securityID == otherModSec.securityID)
                        return false; /// security already exists
                    totalPerc += modsecDB.percentage;
                }
            }

            if (totalPerc < 100)
                return true;
            else
                return false;
        }

    }
}
