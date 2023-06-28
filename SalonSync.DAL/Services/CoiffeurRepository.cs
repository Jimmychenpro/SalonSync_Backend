using Dapper;
using SalonSync.DAL.Entities.DTO;
using SalonSync.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonSync.DAL.Services
{
    public class CoiffeurRepository : ICoiffeurRepository
    {
        private readonly IDbConnection _connection;

        public CoiffeurRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public List<CoiffeurDTO> GetCoiffeurById(int coiffeurId)
        {
            string sql = "SELECT * FROM Coiffeur WHERE Id_Coiffeur = @CoiffeurId";
            return _connection.Query<CoiffeurDTO>(sql, new { CoiffeurId = coiffeurId }).ToList();
        }
        public List<CoiffeurDTO> GetAllCoiffeur()
        {
            string sql = "SELECT * FROM Coiffeur";
            return _connection.Query<CoiffeurDTO>(sql).ToList();

        }
    }
}
