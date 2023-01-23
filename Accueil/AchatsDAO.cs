using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accueil
{
    class AchatsDAO
    {
        //Importer classe mere Mydatabase
        Mydatabase db = new Mydatabase();

        //Creation fonction d'ajout
        public bool AjoutAchats(int idCom, int qttCom, DateTime dateCom, int idCli, int refprod)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `commande`(`IdCom`, `QttCom`, `DateCom`, `IdCli`, `Refprod`) VALUES (@idCom,@QttCom,@DateCom,@idCli,@refprod)",db.getConnection);

            //@idCom,@QttCom,@DateCom,@idCli,@refprod
            cmd.Parameters.Add("@idCom", MySqlDbType.VarChar).Value = idCom;
            cmd.Parameters.Add("@qttCom", MySqlDbType.VarChar).Value = qttCom;
            cmd.Parameters.Add("@dateCom", MySqlDbType.VarChar).Value = dateCom;
            cmd.Parameters.Add("@idCli", MySqlDbType.VarChar).Value = idCli;
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
