using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCompletedGames.Models;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.IdentityModel.Protocols;


namespace My_Completed_Games.DAL
{
    public class GamesDAL : IGamesDAL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private const string SQL_All_Games = "SELECT * FROM MyGames";

        public List<VideoGameModel> AllGames(string id)
        {
            List<VideoGameModel> All_Games = new List<VideoGameModel>();
            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SQL_All_Games, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        VideoGameModel games = new VideoGameModel();
                        games.Title = Convert.ToString(reader["title"]);
                        games.Comments = Convert.ToString(reader["comments"]);
                        games.Backlog = Convert.ToBoolean(reader["backlog"]);
                        games.Playing = Convert.ToBoolean(reader["playing"]);
                        games.Played = Convert.ToBoolean(reader["played"]);
                        games.DateAdded = Convert.ToDateTime(reader["DateAdded"]);
                        games.ImageUrl = Convert.ToString(reader["BoxArt"]);

                        All_Games.Add(games);
                    }
                }
                return All_Games;
            }
            catch(SqlException ex)
            {
                throw;
            }
        }
        
    }
}
