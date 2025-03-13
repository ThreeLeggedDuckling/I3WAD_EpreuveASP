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
    public class UserService : IUserRepository<User>
    {
        private const string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EpreuveASP-DB;Integrated Security=True;";

        public Guid CheckPassword(string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SP_User_CheckPassword";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(nameof(email), email);
                    cmd.Parameters.AddWithValue(nameof(password), password);
                    connection.Open();
                    return (Guid)cmd.ExecuteScalar();
                }
            }
        }

        public void Delete(Guid user_id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SP_User_Delete";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(nameof(user_id), user_id);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public User Get(Guid user_id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SP_User_GetById";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(nameof(user_id), user_id);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToUser();
                        else throw new ArgumentOutOfRangeException();
                    }
                }
            }
        }

        public Guid Insert(User user)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SP_User_Insert";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(nameof(User.Email), user.Email);
                    cmd.Parameters.AddWithValue(nameof(User.Username), user.Username);
                    cmd.Parameters.AddWithValue(nameof(User.Password), user.Password);
                    connection.Open();
                    return (Guid)cmd.ExecuteScalar();
                }
            }
        }

        public void Update(Guid user_id, User user)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SP_User_Update";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(nameof(user_id), user_id);
                    cmd.Parameters.AddWithValue(nameof(user.Username), user.Username);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
