using Dapper;
using SalonSync.DAL.Entities;
using SalonSync.DAL.Entities.DTO;
using SalonSync.DAL.Models;
using SalonSync.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonSync.DAL.Services
{
    public class CalendrierRepository : ICalendrierRepository
    {
        private readonly IDbConnection _connection;

        public CalendrierRepository(IDbConnection connection)
        {
            _connection = connection;
        }
        public List<Calendrier> GetAllCalendrier()
        {
            string sql = "SELECT * FROM Calendrier";
            return _connection.Query<Calendrier>(sql).ToList();
        }
    }
}


