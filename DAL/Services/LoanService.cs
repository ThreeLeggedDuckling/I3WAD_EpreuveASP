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
    public class LoanService : ILoanRepository<Loan>
    {
        private const string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EpreuveASP-DB;Integrated Security=True;";

        public Loan Get(Guid loan_id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SP_Loan_GetById";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(nameof(loan_id), loan_id);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToLoan();
                        else throw new ArgumentOutOfRangeException();
                    }
                }
            }
        }

        public IEnumerable<Loan> GetByBorrower(Guid borrower_id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SP_Loan_GetByBorrower";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("borrower", borrower_id);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToLoan();
                        }
                    }
                }
            }
        }

        public IEnumerable<Loan> GetByLender(Guid lender_id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SP_Loan_GetByLender";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("lender", lender_id);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToLoan();
                        }
                    }
                }
            }
        }

        public Guid Insert(Guid user_id, Loan loan)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SP_Loan_Insert";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(nameof(user_id), user_id);
                    cmd.Parameters.AddWithValue("copy_id", loan.Copy);
                    cmd.Parameters.AddWithValue(nameof(loan.LoanDate), loan.LoanDate);
                    cmd.Parameters.AddWithValue(nameof(loan.ReturnDate), loan.ReturnDate);
                    cmd.Parameters.AddWithValue(nameof(loan.Borrower), loan.Borrower);
                    connection.Open();
                    return (Guid)cmd.ExecuteScalar();
                }
            }
        }

        public void Update(Guid loan_id, Loan loan)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SP_Loan_Update";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(nameof(loan_id), loan_id);
                    cmd.Parameters.AddWithValue(nameof(loan.ReturnDate), loan.ReturnDate);
                    cmd.Parameters.AddWithValue(nameof(loan.LenderScore), loan.LenderScore);
                    cmd.Parameters.AddWithValue(nameof(loan.BorrowerScore), loan.BorrowerScore);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
