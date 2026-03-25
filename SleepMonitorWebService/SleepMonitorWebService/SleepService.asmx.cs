using System.Configuration;
using System.Data.SqlClient;
using System.Web.Services;
using System;
using SleepMonitorWebService.Models;
using System.Collections.Generic;

namespace SleepMonitorWebService
{
    [WebService(Namespace = "http://sleepmonitor.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class SleepService : System.Web.Services.WebService
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        [WebMethod(Description = "Adaugă o noapte de somn")]
        public string AddSleepEntry(DateTime sleepTime, DateTime wakeTime, int sleepScore, string notes)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO SleepLog (SleepTime, WakeTime, SleepScore, Notes) VALUES (@sleep, @wake, @score, @notes)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@sleep", sleepTime);
                cmd.Parameters.AddWithValue("@wake", wakeTime);
                cmd.Parameters.AddWithValue("@score", sleepScore);
                cmd.Parameters.AddWithValue("@notes", notes);
                conn.Open();
                cmd.ExecuteNonQuery();
                return "Entry added successfully";
            }
        }

        [WebMethod(Description = "Modifică o intrare de somn")]
        public string UpdateSleepEntry(int id, DateTime sleepTime, DateTime wakeTime, int sleepScore, string notes)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE SleepLog SET SleepTime=@sleep, WakeTime=@wake, SleepScore=@score, Notes=@notes WHERE Id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@sleep", sleepTime);
                cmd.Parameters.AddWithValue("@wake", wakeTime);
                cmd.Parameters.AddWithValue("@score", sleepScore);
                cmd.Parameters.AddWithValue("@notes", notes);
                conn.Open();
                cmd.ExecuteNonQuery();
                return "Entry updated successfully";
            }
        }

        [WebMethod(Description = "Returnează toate înregistrările de somn")]
        public SleepEntry[] GetAllSleepEntries()
        {
            var entries = new List<SleepEntry>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, SleepTime, WakeTime, SleepScore, Notes FROM SleepLog";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    entries.Add(new SleepEntry
                    {
                        Id = reader.GetInt32(0),
                        SleepTime = reader.GetDateTime(1),
                        WakeTime = reader.GetDateTime(2),
                        SleepScore = reader.GetInt32(3),
                        Notes = reader.GetString(4)
                    });
                }
            }
            return entries.ToArray();
        }

        [WebMethod(Description = "Șterge o înregistrare de somn după ID")]
        public string DeleteSleepEntry(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM SleepLog WHERE Id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0 ? "Entry deleted successfully" : "Entry not found";
            }
        }
    }
}
