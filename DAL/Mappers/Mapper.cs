using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    static class Mapper
    {
        public static Copy ToCopy(this IDataRecord record)
        {
            if (record is null) throw new ArgumentNullException(nameof(record));
            return new Copy()
            {
                Copy_Id = (Guid)record[nameof(Copy.Copy_Id)],
                Game = (Guid)record[nameof(Copy.Game)],
                Owner = (Guid)record[nameof(Copy.Owner)],
                State = (string)record[nameof(Copy.State)]
            };
        }

        public static Game ToGame(this IDataRecord record)
        {
            if (record is null) throw new ArgumentNullException(nameof(record));
            return new Game()
            {
                Game_Id = (Guid)record[nameof(Game.Game_Id)],
                Name = (string)record[nameof(Game.Name)],
                Description = (string)record[nameof(Game.Description)],
                AgeMin = (byte)record[nameof(Game.AgeMin)],
                AgeMax = (byte)record[nameof(Game.AgeMax)],
                NbPlayersMin = (byte)record[nameof(Game.NbPlayersMin)],
                NbPlayersMax = (byte)record[nameof(Game.NbPlayersMax)],
                CreatedAt = (DateTime)record[nameof(Game.CreatedAt)]
            };
        }

        public static Loan ToLoan(this IDataRecord record)
        {
            if (record is null) throw new ArgumentNullException(nameof(record));
            return new Loan()
            {
                Loan_Id = (Guid)record[nameof(Loan.Loan_Id)],
                Copy = (Guid)record[nameof(Loan.Copy)],
                LoanDate = (DateTime)record[nameof(Loan.LoanDate)],
                ReturnDate = (record[nameof(Loan.ReturnDate)] is DBNull) ? null : (DateTime?)record[nameof(Loan.ReturnDate)],
                Lender = (Guid)record[nameof(Loan.Lender)],
                LenderScore = (record[nameof(Loan.LenderScore)] is DBNull) ? null : (byte?)record[nameof(Loan.LenderScore)],
                Borrower = (Guid)record[nameof(Loan.Borrower)],
                BorrowerScore = (record[nameof(Loan.BorrowerScore)] is DBNull) ? null : (byte?)record[nameof(Loan.Borrower)],
            };
        }

        public static Tag ToTag(this IDataRecord record)
        {
            if (record is null) throw new ArgumentException(nameof(record));
            return new Tag()
            {
                Tag_Id = (string)record[nameof(Tag.Tag_Id)]
            };
        }

        public static User ToUser(this IDataRecord record)
        {
            if (record is null) throw new ArgumentNullException(nameof(record));
            return new User()
            {
                User_Id = (Guid)record[nameof(User.User_Id)],
                Email = (string)record[nameof(User.Email)],
                Username = (string)record[nameof(User.Username)],
                Password = "********",
                CreatedAt = (DateTime)record[nameof(User.CreatedAt)],
                DisabledAt = (record[nameof(User.DisabledAt)] is DBNull) ? null : (DateTime?)record[nameof(User.DisabledAt)]
            };
        }

    }
}
