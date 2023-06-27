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
    public class CoiffeurService : ICoiffeurRepository
    {
        private readonly IDbConnection _connection;

        public CoiffeurService(IDbConnection connection)
        {
            _connection = connection;
        }

        public List<CoiffeurDTO> GetCoiffeur(int coiffeurId)
        {
            string sql = "SELECT * FROM Coiffeur WHERE Id_Coiffeur = @CoiffeurId";
            return _connection.Query<CoiffeurDTO>(sql, new { CoiffeurId = coiffeurId }).ToList();
        }
    }
}
