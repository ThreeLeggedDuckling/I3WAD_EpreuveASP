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
        public static User ToUser(this IDataRecord record)
        {
            if (record is null) throw new ArgumentNullException(nameof(record));
            return new User()
            {
                User_Id = (Guid)record[nameof(User.User_Id)],
                Email = (string)record[nameof(User.Email)],
                Username = (string)record[nameof(User.Username)],
                Password = (string)record[nameof(User.Password)],
                Salt = (Guid)record[nameof(User.Salt)],
                CreatedAt = (DateTime)record[nameof(User.CreatedAt)],
                DisabledAt = (record[nameof(User.DisabledAt)] is DBNull) ? null : (DateTime?)record[nameof(User.DisabledAt)]
            };
        }

        // game

        // tag

        // copy

        // loan

        // gametag

    }
}
