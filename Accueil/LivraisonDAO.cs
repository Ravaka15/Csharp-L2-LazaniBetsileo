using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accueil
{
    class LivraisonDAO
    {
        //Importer classe mere Mydatabase
        Mydatabase db = new Mydatabase();

        //Creation fonction d'ajout
        public bool AjoutLivraison(int idLiv, int qttLiv, DateTime dateLiv, int idFrs, int refprod)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `livrer`(`IdLiv`, `QttLiv`, `DateLiv`, `IdFrs`, `Refprod`) VALUES (@idLiv,@QttLiv,@DateLiv,@idFrs,@refprod)", db.getConnection);

            // @idLiv,@QttLiv,@DateLiv,@idFrs,@refprod
            cmd.Parameters.Add("@idLiv", MySqlDbType.VarChar).Value =idLiv;
            cmd.Parameters.Add("@qttLiv", MySqlDbType.VarChar).Value = qttLiv;
            cmd.Parameters.Add("@dateLiv", MySqlDbType.VarChar).Value = dateLiv;
            cmd.Parameters.Add("@idFrs", MySqlDbType.VarChar).Value =idFrs;
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
