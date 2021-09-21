using Entity = Building.Domain.Entities;
using Building.DAL.IRepositories;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;

namespace Building.DAL.Repositories
{
    public class ObjectRepository : IObjectRepository
    {
        private readonly string _connectionString;

        public ObjectRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<IReadOnlyList<Entity.Object>> GetAllAsync()
        {
            const string sql = "SELECT * FROM Object";
            using var connection = new SqlConnection(_connectionString);

            var result = await connection.QueryAsync<Entity.Object>(sql);
            return result.ToList();
        }
    }
}
