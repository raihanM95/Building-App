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
    public class DataFieldRepository : IDataFieldRepository
    {
        private readonly string _connectionString;

        public DataFieldRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<IReadOnlyList<Entity.DataField>> GetAllAsync()
        {
            const string sql = "SELECT * FROM DataField";
            using var connection = new SqlConnection(_connectionString);

            var result = await connection.QueryAsync<Entity.DataField>(sql);
            return result.ToList();
        }
    }
}
