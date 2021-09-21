using Building.DAL.IRepositories;
using Building.Domain.DTOs;
using Building.Domain.Entities;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.DAL.Repositories
{
    public class ReadingRepository : IReadingRepository
    {
        private readonly string _connectionString;

        public ReadingRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<IReadOnlyList<Reading>> GetAllAsync()
        {
            const string sql = "EXEC Readings";
            using var connection = new SqlConnection(_connectionString);

            var result = await connection.QueryAsync<Reading>(sql);
            return result.ToList();
        }

        public async Task<IReadOnlyList<Reading>> GetAllFilteredAsync(ReadingDto readingDto)
        {
            var sql = $@"EXEC FilteredReading {readingDto.BuildingId}, {readingDto.ObjectId}, 
                      {readingDto.DataFieldId}, '{readingDto.TimestampFrom}', '{readingDto.TimestampTo}'";

            using var connection = new SqlConnection(_connectionString);

            var result = await connection.QueryAsync<Reading>(sql);
            return result.ToList();
        }
    }
}
