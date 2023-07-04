using Dapper;
using SalonSync.DAL.Entities;
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
    public class PlageHoraireRepository : IPlageHoraireRepository
    {
        private readonly IDbConnection _connection;

        public PlageHoraireRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public List<PlageHoraireDTO> GetAllPlageHoraires()
        {
            string sql = "SELECT * FROM PlageHoraire";
            return _connection.Query<PlageHoraireDTO>(sql).ToList();
        }

        public List<PlageHoraireDTO> GetPlageHorairesByCoiffeur(int coiffeurId)
        {
            string sql = "SELECT heureDebut, PlageHoraireDate FROM PlageHoraire WHERE Id_Coiffeur = @CoiffeurId";
            return _connection.Query<PlageHoraireDTO>(sql, new { CoiffeurId = coiffeurId }).ToList();
        }
    }
}
