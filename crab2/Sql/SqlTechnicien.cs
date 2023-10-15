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
    public static class SqlTechnicien
    {
        public static Technicien FindId(int param)
        {
            List<string> TechnicienJsonList = new List<string>();

            Technicien resultat = null;

            string connectionString = "Server=localhost;UserId=root;Password=;Database=Crab2";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = @"SELECT JSON_OBJECT('Matricule', Matricule, 'Nom', Nom, 'Prenom', Prenom) 
                                   FROM Technicien
                                   WHERE Id = @param";

                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@param", param);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string userJson = reader.GetString(0);  // considering the JSON is in the first column
                            resultat = JsonConvert.DeserializeObject<Technicien>(userJson);
                        }
                    }
                }
            }
            return resultat;
        }

        public static Technicien FindNom(string nom)
        {
            Technicien resultat = null;

            string connectionString = "Server=localhost;UserId=root;Password=;Database=Crab2";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = @"SELECT JSON_OBJECT('Matricule', Matricule, 'Nom', Nom, 'Prenom', Prenom) 
                               FROM Technicien
                               WHERE Nom = @nom";

                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@nom", nom);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string userJson = reader.GetString(0);  // considering the JSON is in the first column
                            resultat = JsonConvert.DeserializeObject<Technicien>(userJson);
                        }
                    }
                }
            }
            return resultat;
        }

        public static List<Technicien> FindAll()
        {
            List<Technicien> techniciensList = new List<Technicien>();
            string connectionString = "Server=localhost;UserId=root;Password=;Database=Crab2";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = @"SELECT JSON_OBJECT('Matricule', Matricule, 'Nom', Nom, 'Prenom', Prenom) 
                               FROM Technicien";

                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string technicienJson = reader.GetString(0);
                            Technicien technicien = JsonConvert.DeserializeObject<Technicien>(technicienJson);
                            techniciensList.Add(technicien);
                        }
                    }
                }
            }
            return techniciensList;
        }
    }
}


