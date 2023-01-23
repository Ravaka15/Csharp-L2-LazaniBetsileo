using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accueil
{
    class ProduitDAO
    {
        //Importer classe mere Mydatabase
        Mydatabase db = new Mydatabase();

        //Creation fonction d'ajout
        public bool AjoutProduit(string nomprod, string type, int prixprod, int qttprod)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `produit`(`Nomprod`, `Typeprod`, `Prixprod`, `Qttprod`) VALUES (@nomprod,@type,@prixprod,@qttprod)", db.getConnection);

            //@refprod,@nomprod,@type,@prixprod,@qttprod
            cmd.Parameters.Add("@nomprod", MySqlDbType.VarChar).Value = nomprod;
            cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = type;
            cmd.Parameters.Add("@prixprod", MySqlDbType.VarChar).Value = prixprod;
            cmd.Parameters.Add("@qttprod", MySqlDbType.VarChar).Value = qttprod;

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
        public bool ModifierProduit(int refprod ,string nomprod, string type, int prixprod, int qttprod)
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE `produit` SET `Nomprod`=@nomprod,`Typeprod`=@type,`Prixprod`=@prixprod,`Qttprod`=@qttprod WHERE Refprod=@refprod", db.getConnection);

            //@refprod,@nomprod,@type,@prixprod,@qttprod
            cmd.Parameters.Add("@nomprod", MySqlDbType.VarChar).Value = nomprod;
            cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = type;
            cmd.Parameters.Add("@prixprod", MySqlDbType.VarChar).Value = prixprod;
            cmd.Parameters.Add("@qttprod", MySqlDbType.VarChar).Value = qttprod;
            cmd.Parameters.Add("@refprod", MySqlDbType.VarChar).Value = refprod;

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
        public bool SupprimerProduit(int refprod)
        {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM produit WHERE Refprod=@refprod", db.getConnection);

            cmd.Parameters.Add("@refprod", MySqlDbType.VarChar).Value = refprod;

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
