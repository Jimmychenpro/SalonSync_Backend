using SalonSync.BLL.Interfaces;
using SalonSync.DAL.Entities.DTO;
using SalonSync.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonSync.BLL.Services
{
    public class CoiffeurService : ICoiffeurService
    {
        private readonly ICoiffeurRepository _coiffeurRepository;

        public CoiffeurService(ICoiffeurRepository coiffeurRepository)
        {
            _coiffeurRepository = coiffeurRepository;
        }

        public List<CoiffeurDTO> GetCoiffeur(int coiffeurId)
        {
            return _coiffeurRepository.GetCoiffeur(coiffeurId);
        }
    }
}
