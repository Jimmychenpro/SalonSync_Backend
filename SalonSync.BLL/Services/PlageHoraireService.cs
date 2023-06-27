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

        
        
        
        
        public List<PlageHoraireDTO> GetPlagesHoraires(int coiffeurId )
        {
            return _plageHoraireRepository.GetPlageHoraires( coiffeurId );
    
        }


            //TimeSpan heureDebut = new TimeSpan(8, 0, 0); // 08:00
            //TimeSpan heureFin = new TimeSpan(20, 0, 0); // 20:00
            //TimeSpan pas = new TimeSpan(0, 30, 0); // Pas de 30 minutes

            //while (heureDebut < heureFin)
            //{
            //    PlageHoraire plageHoraire = new PlageHoraire
            //    {
            //        HeureDebut = heureDebut,
            //        HeureFin = heureDebut.Add(pas)
            //    };

            //    plagesHoraires.Add(plageHoraire);

            //    heureDebut = heureDebut.Add(pas);
            //}

    }
}
