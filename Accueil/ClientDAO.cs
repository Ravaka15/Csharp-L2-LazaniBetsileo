 using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Accueil
{
    class ClientDAO
    {
        //Importer classe mere Mydatabase
        Mydatabase db = new Mydatabase();

        //Creation fonction d'ajout
        public bool AjoutClient(string nomCli, string prenomCli, string adresseCli, string telCli,string villeCli,string cinCli)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `client`( `NomCli`, `PrenomCli`, `AdresseCli`, `TelephoneCli`, `VilleCli`, `CIN`) VALUES (@nomCli,@prenomCli,@adresseCli,@telCli,@villeCli,@cinCli)", db.getConnection);

            //@nomCli,@prenomCli,@adresseCli,@telCli,@villeCli,@cinCli
            cmd.Parameters.Add("@nomCli", MySqlDbType.VarChar).Value = nomCli;
            cmd.Parameters.Add("@prenomCli", MySqlDbType.VarChar).Value = prenomCli;
            cmd.Parameters.Add("@adresseCli", MySqlDbType.VarChar).Value = adresseCli;
            cmd.Parameters.Add("@telCli", MySqlDbType.VarChar).Value = telCli;
            cmd.Parameters.Add("@villeCli", MySqlDbType.VarChar).Value = villeCli;
            cmd.Parameters.Add("@cinCli", MySqlDbType.VarChar).Value = cinCli;

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
        public bool ModifierClient(int idCli ,string nomCli, string prenomCli, string adresseCli, string telCli, string villeCli, string cinCli)
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE `client` SET `NomCli`=@nomCli,`PrenomCli`=@prenomCli,`AdresseCli`=@adresseCli,`TelephoneCli`=@telCli,`VilleCli`=@villeCli,`CIN`=@cinCli WHERE IdCli = @idCli", db.getConnection);

            //@nomCli,@prenomCli,@adresseCli,@telCli,@villeCli,@cinCli
            cmd.Parameters.Add("@nomCli", MySqlDbType.VarChar).Value = nomCli;
            cmd.Parameters.Add("@prenomCli", MySqlDbType.VarChar).Value = prenomCli;
            cmd.Parameters.Add("@adresseCli", MySqlDbType.VarChar).Value = adresseCli;
            cmd.Parameters.Add("@telCli", MySqlDbType.VarChar).Value = telCli;
            cmd.Parameters.Add("@villeCli", MySqlDbType.VarChar).Value = villeCli;
            cmd.Parameters.Add("@cinCli", MySqlDbType.VarChar).Value = cinCli;
            cmd.Parameters.Add("@idCli", MySqlDbType.VarChar).Value = idCli;

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
        public bool SupprimerClient(int idCli)
        { 
             MySqlCommand cmd = new MySqlCommand("DELETE FROM client WHERE IdCli=@idCli",db.getConnection);

             cmd.Parameters.Add("@idCli", MySqlDbType.VarChar).Value = idCli;

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

        //Creation tableau Client
        public DataTable chargertableauClient()
        { 
            MySqlCommand cmd = new MySqlCommand("SELECT `IdCli`, `NomCli`, `PrenomCli`, `AdresseCli`, `TelephoneCli`, `VilleCli`, `CIN` FROM `client`",db.getConnection);
            
            db.openConnection();
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            return table;
          
        }

        

    }
}



















/*string sql = "datasource=localhost;port=3309;username=root;password=;database=lazanibetsileo";
           MySqlConnection cnx = new MySqlConnection(sql);
           try
           {
               cnx.Open();
           }
           catch (MySqlException ex)
           {
               MessageBox.Show("MySQL Connection !! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           return cnx;
       }
       // ajout Client
       public void Create_data(ClientEntity std) 
       {
           string sql = "INSERT INTO client(nomCli,adressCli,telCli,prenomCli,cinCli,VilleCli) values(@nom,@add,@tel,@prenom,@cin,@ville)";
           MySqlConnection cnx = GetConnection();
           MySqlCommand cmd = new MySqlCommand(sql, cnx);
           cmd.CommandType = CommandType.Text;
           
           try
           {
               cmd.ExecuteNonQuery();
               MessageBox.Show("Bien enregistrer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           catch (MySqlException ex)
           {
               MessageBox.Show("MySQL Connection !! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           cnx.Close();
       }
       //modification client
       public void update_data(ClientEntity std, string idc)
       {
           string sql = "UPDATE client SET nomCli=@nom , adressCli=@add, telCli=@tel, prenomCli=@prenom, cinCli=@cin, VilleCli=@ville where idCli =@idc";
           MySqlConnection cnx = GetConnection();
           MySqlCommand cmd = new MySqlCommand(sql, cnx);
           cmd.CommandType = CommandType.Text;
           cmd.Parameters.Add("@nom", MySqlDbType.VarChar).Value = std.Nom;
           cmd.Parameters.Add("@add", MySqlDbType.VarChar).Value = std.Add;
           cmd.Parameters.Add("@tel", MySqlDbType.VarChar).Value = std.Tel;
           cmd.Parameters.Add("@prenom", MySqlDbType.VarChar).Value = std.Prenom;
           cmd.Parameters.Add("@cin", MySqlDbType.VarChar).Value = std.Cin;
           cmd.Parameters.Add("@ville", MySqlDbType.VarChar).Value = std.Ville;
           try
           {
               cmd.ExecuteNonQuery();
               MessageBox.Show("Bien modifier", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           catch (MySqlException ex)
           {
               MessageBox.Show("non modification  !! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           cnx.Close();
       }

       //supression 
       public void delete_data(string idc)
       {       
               string sql = "DELETE FROM client where idCli =@idc";
               MySqlConnection cnx = GetConnection();
               MySqlCommand cmd = new MySqlCommand(sql, cnx);
               cmd.CommandType = CommandType.Text;
               cmd.Parameters.Add("@idc", MySqlDbType.VarChar).Value = idc;
               try
               {
                   cmd.ExecuteNonQuery();
                   MessageBox.Show("Suppresion termine", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
               catch (MySqlException ex)
               {
               MessageBox.Show("non Supprime  !! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
           cnx.Close();
       }
       public static void ChercheClient(string query, DataGridView dgv)
       {
           string sql = query;
           MySqlConnection cnx = GetConnection();
           MySqlCommand cmd = new MySqlCommand(sql, cnx);
           MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
           DataTable tbl = new DataTable();
           adp.Fill(tbl);
           cnx.Close();*/