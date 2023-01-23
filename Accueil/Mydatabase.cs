using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Accueil
{
    class Mydatabase
    {
        //connection any am base de donnee
        private MySqlConnection cnx = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=lazanibetsileo");
        private MySqlCommand cmd = new MySqlCommand();
        DataTable data = new DataTable();
        MySqlDataAdapter Dta = new MySqlDataAdapter();

        DataSet DS = new DataSet();

        public MySqlConnection getConnection
        {
            get
            {
                return cnx;
            }
        }

        //Ouverture de la connection
        public void openConnection()
        {
            if (cnx.State == ConnectionState.Closed)
            {
                cnx.Open();
                Console.Write("yes connecter");
            }
        }
        
        //Fermeture de la connex
        public void closeConnection()
        {
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
                Console.Write("no connecter");
            }
        }

    }
}
 