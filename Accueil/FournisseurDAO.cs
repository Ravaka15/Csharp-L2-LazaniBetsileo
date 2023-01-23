using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Accueil
{
    class FournisseurDAO
    {
        //Importer classe mere Mydatabase
        Mydatabase db = new Mydatabase();

        //Creation fonction d'ajout
        public bool AjoutFournisseur(string nomFrs, string prenomFrs, string adresseFrs,string telFrs)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO fournisseur(`NomFrs`, `PrenomFrs`, `AdresseFrs`, `TelephoneFrs`) VALUES (@nomFrs,@prenomFrs,@adresseFrs,@telFrs)",db.getConnection);
            
            //@nomFrs,@prenomFrs,@adresseFrs,@telFrs
            cmd.Parameters.Add("@nomFrs", MySqlDbType.VarChar).Value = nomFrs;
            cmd.Parameters.Add("@prenomFrs", MySqlDbType.VarChar).Value = prenomFrs;
            cmd.Parameters.Add("@adresseFrs", MySqlDbType.VarChar).Value = adresseFrs;
            cmd.Parameters.Add("@telFrs", MySqlDbType.VarChar).Value = telFrs;

            db.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
            
        }

        //Creation fonction de modification
        public bool ModifierFournisseur(int idFrs ,string nomFrs, string prenomFrs, string adresseFrs, string telFrs)
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE `fournisseur` SET `NomFrs`=@nomFrs,`PrenomFrs`=@prenomFrs,`AdresseFrs`=@adresseFrs,`TelephoneFrs`=@telFrs WHERE IdFrs = @idFrs", db.getConnection);

            //@nomFrs,@prenomFrs,@adresseFrs,@telFrs
            cmd.Parameters.Add("@nomFrs", MySqlDbType.VarChar).Value = nomFrs;
            cmd.Parameters.Add("@prenomFrs", MySqlDbType.VarChar).Value = prenomFrs;
            cmd.Parameters.Add("@adresseFrs", MySqlDbType.VarChar).Value = adresseFrs;
            cmd.Parameters.Add("@telFrs", MySqlDbType.VarChar).Value = telFrs;
            cmd.Parameters.Add("@idFrs", MySqlDbType.VarChar).Value = idFrs;

            db.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
        
        //Creation fonction de suppression
        public bool SupprimerFournisseur(int idFrs)
        { 
             MySqlCommand cmd = new MySqlCommand("DELETE FROM fournisseur WHERE IdFrs=@idFrs",db.getConnection);

             cmd.Parameters.Add("@idFrs", MySqlDbType.VarChar).Value = idFrs;

             db.openConnection();
             if (cmd.ExecuteNonQuery() == 1)
             {
                 db.closeConnection();
                 return true;
             }
             else
             {
                 db.closeConnection();
                 return false;
             }
        }
    }
}
