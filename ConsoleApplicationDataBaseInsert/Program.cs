using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationDataBaseInsert
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2016,11,4,12,0,0);
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    Console.WriteLine(dateTime + " " + j);
                    DbConnect(1, 17, 55, dateTime, j);
                    DbConnect(2, 8, 34, dateTime, j);
                    DbConnect(3, 12, 36, dateTime, j);
                    DbConnect(4, 0, 5, dateTime, j);
                    DbConnect(5, 1, 2, dateTime, j);
                }
                dateTime = dateTime.AddMinutes(30);
            }
        }

        private static void DbConnect(int currentCompoundNumber, int randMin, int randMax, DateTime dateTime, int messurementStationId)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = "Server=(LocalDb)\\ProjectsV12;Database=Dissertation;Trusted_Connection=true";
                con.Open();
                string queryAirData = "INSERT INTO AirData (Compounds_id, Value, MessurementStation_id, Timestamp)";
                queryAirData += " VALUES (@Compounds_id, @Value, @MessurementStation_id, @Timestamp)";
                SqlCommand commandAirData = new SqlCommand(queryAirData, con);
                commandAirData.Parameters.AddWithValue("@Compounds_id", currentCompoundNumber);
                commandAirData.Parameters.AddWithValue("@Value", RandDouble(randMin, randMax));
                commandAirData.Parameters.AddWithValue("@MessurementStation_id", messurementStationId);
                commandAirData.Parameters.AddWithValue("@Timestamp", dateTime);
                commandAirData.ExecuteNonQuery();
            }
        }

        private static double RandDouble(double minValue, double maxValue)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            var nextRandomDouble = random.NextDouble();
            return minValue + (nextRandomDouble * (maxValue - minValue));
        }
    }
}
