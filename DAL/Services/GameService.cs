using Common.Repositories;
using DAL.Entities;
using DAL.Mappers;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public class GameService : IGameRepository<Game>
    {
        private const string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EpreuveASP-DB;Integrated Security=True;";

        public string AddTag(Guid game_id, string tag)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SP_GameTag_Insert";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(nameof(game_id), game_id);
                    cmd.Parameters.AddWithValue(nameof(tag), tag);
                    connection.Open();
                    return (string)cmd.ExecuteScalar();
                }
            }
        }

        public IEnumerable<Game> Get()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SP_Game_GetAll";
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToGame();
                        }
                    }
                }
            }
        }

        public Game Get(Guid game_id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
               using (SqlCommand cmd = connection.CreateCommand())
               {
                    cmd.CommandText = "SP_Game_GetById";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(nameof(game_id), game_id);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToGame();
                        else throw new ArgumentOutOfRangeException();
                    }
               }
            }
        }

        public IEnumerable<Game> GetByName(string name)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
               using (SqlCommand cmd = connection.CreateCommand())
               {
                    cmd.CommandText = "SP_Game_GetByName";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(nameof(name), name);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToGame();
                        }
                    }
               }
            }
        }

        public IEnumerable<Game> GetByTag(string tag)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
               using (SqlCommand cmd = connection.CreateCommand())
               {
                    cmd.CommandText = "SP_Game_GetByTag";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(nameof(tag), tag);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToGame();
                        }
                    }
               }
            }
        }

        public IEnumerable<Game> GetNPopular(int nb_results)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
               using (SqlCommand cmd = connection.CreateCommand())
               {
                    cmd.CommandText = "SP_Game_GetNPopular";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(nameof(nb_results), nb_results);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToGame();
                        }
                    }
               }
            }
        }

        public Guid Insert(Game game)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
               using (SqlCommand cmd = connection.CreateCommand())
               {
                    cmd.CommandText = "SP_Game_Insert";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(nameof(game.Name), game.Name);
                    cmd.Parameters.AddWithValue(nameof(game.Description), game.Description);
                    cmd.Parameters.AddWithValue("age_min", game.AgeMin);
                    cmd.Parameters.AddWithValue("age_max", game.AgeMax);
                    cmd.Parameters.AddWithValue("nb_players_min", game.NbPlayersMin);
                    cmd.Parameters.AddWithValue("nb_players_max", game.NbPlayersMax);
                    cmd.Parameters.AddWithValue("playing_time", game.PlayingTime);
                    connection.Open();
                    return (Guid)cmd.ExecuteScalar();
               }
            }
        }
    }
}
