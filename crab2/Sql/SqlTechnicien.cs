using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using crab2.Modeles;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace crab2.Sql
{
    public static  class SqlTechnicien
    {
        public static Technicien FindId (int param)
        {
            Technicien resultat = null;

            string connectionString = "Server=localhost;UserId=root;Password=;Database=Crab2";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = @"SELECT JSON_OBJECT('Matricule', Matricule, 'Nom', Nom, 'Prenom', Prenom) 
                                   FROM Technicien
                                   WHERE Id = @Param";

                /////////code/////////////

            }
            return resultat;
        }
    }
}
