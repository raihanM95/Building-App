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
    public class BuildingRepository : IBuildingRepository
    {
        private readonly string _connectionString;

        public BuildingRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<IReadOnlyList<Entity.Building>> GetAllAsync()
        {
            const string sql = "SELECT * FROM Building";
            using var connection = new SqlConnection(_connectionString);

            var result = await connection.QueryAsync<Entity.Building>(sql);
            return result.ToList();
        }
    }
}
