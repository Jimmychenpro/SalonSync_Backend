using SalonSync.BLL.Interfaces;
using SalonSync.DAL.Entities;
using SalonSync.DAL.Entities.DTO;
using SalonSync.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonSync.BLL.Services
{
    public class PlageHoraireService : IPlageHoraireService
    {
        public readonly IPlageHoraireRepository _plageHoraireRepository;

        public PlageHoraireService(IPlageHoraireRepository plageHoraireRepository)
        {
            _plageHoraireRepository = plageHoraireRepository;
        }

        public List<PlageHoraireDTO> GetAllPlageHoraires()
        {
            return _plageHoraireRepository.GetAllPlageHoraires();
        }

        public List<PlageHoraireDTO> GetPlageHorairesByCoiffeur(int coiffeurId )
        {
            return _plageHoraireRepository.GetPlageHorairesByCoiffeur( coiffeurId );
    
        }

    }
}
