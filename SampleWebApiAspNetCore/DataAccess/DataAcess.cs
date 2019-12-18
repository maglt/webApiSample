using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using SampleWebApiAspNetCore.Models;

namespace DataAccess
{
    public class SqlDataAccess
    {

        IDbConnection connection = null;

        public SqlDataAccess(IDbConnection connection)
        {
            this.connection = connection;
        }
       

        public List<User> GetUserModel()
        {
            using (connection)
            {
                return connection.Query<User>("SELECT [Id],[UserName],[Email] FROM [NbaFantasy].[dbo].[User]").ToList();
            }
        }

    }

}

