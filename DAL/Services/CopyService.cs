using Common.Repositories;
using DAL.Entities;
using DAL.Mappers;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public class CopyService : BaseService, ICopyRepository<Copy>
    {
        public CopyService(IConfiguration config) : base(config, "Main-DB") { }

        public void Delete(Guid copy_id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SP_Copy_Delete";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(nameof(copy_id), copy_id);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Copy Get(Guid copy_id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SP_Copy_GetById";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(nameof(copy_id), copy_id);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToCopy();
                        else throw new ArgumentOutOfRangeException();
                    }
                }
            }
        }

        public IEnumerable<Copy> GetByGame(Guid game)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SP_Copy_GetByGame";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(nameof(game), game);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToCopy();
                        }
                    }
                }
            }
        }

        public Guid Insert(Copy copy)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SP_Copy_Insert";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("game_id", copy.Game);
                    cmd.Parameters.AddWithValue("user_id", copy.Owner);
                    cmd.Parameters.AddWithValue(nameof(copy.State), copy.State);
                    connection.Open();
                    return (Guid)cmd.ExecuteScalar();
                }
            }
        }

        public void Update(Guid copy_id, Copy copy)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SP_Copy_Update";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(nameof(copy_id), copy_id);
                    cmd.Parameters.AddWithValue(nameof(copy.State), copy.State);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
