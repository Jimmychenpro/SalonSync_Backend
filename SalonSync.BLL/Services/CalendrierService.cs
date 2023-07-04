using SalonSync.BLL.Interfaces;
using SalonSync.DAL.Entities;
using SalonSync.DAL.Entities.DTO;
using SalonSync.DAL.Repositories.Interfaces;
using SalonSync.DAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SalonSync.BLL.Services
{
    public class CalendrierService : ICalendrierService
    {
        private readonly ICalendrierRepository _calendrierRepository;
        private readonly IPlageHoraireRepository _plageHoraireRepository;


        public CalendrierService(ICalendrierRepository calendrierRepository, IPlageHoraireRepository plageHoraireRepository)
        {
            _calendrierRepository = calendrierRepository;
            _plageHoraireRepository = plageHoraireRepository;
        }


       


        public List<Calendrier> GetAllCalendrier()
        {
            return _calendrierRepository.GetAllCalendrier();
        }

        public List<Calendrier> GetDisponibilites(int coiffeurId)
        {
            List<PlageHoraireDTO> plageIndisponibles = _plageHoraireRepository.GetPlageHorairesByCoiffeur(coiffeurId);
            List<Calendrier> calendrier = _calendrierRepository.GetAllCalendrier();



            foreach (PropertyInfo joursSemaines in typeof(Calendrier).GetProperties())
            {
                for (int i = 0; i < calendrier.Count; i++)
                {
                    calendrier[0].Lundi
                }
            }


        }



        public async task<calendrier> getcalendriersansplagesindisponibles(int coiffeurid)
        {
            // récupérez les plages horaires indisponibles pour le coiffeur
            list<plagehoraire> plagesindisponibles = await getplagehorairesbycoiffeur(coiffeurid);

            // récupérez le calendrier complet
            calendrier calendrier = await getallcalendrier();

            // parcourez les plages horaires indisponibles et supprimez-les du calendrier
            foreach (plagehoraire plageindisponible in plagesindisponibles)
            {
                // recherchez la plage horaire correspondante dans le calendrier
                foreach (var joursemaine in calendrier.jourssemaine)
                {
                    plageindisponible.date = joursemaine.jour;
                    var plagehoraire = joursemaine.plageshoraires.firstordefault(p => p.heuredebut == plageindisponible.heuredebut && p.heurefin == plageindisponible.heurefin);

                    // supprimez la plage horaire indisponible si elle est présente dans le calendrier
                    if (plagehoraire != null)
                    {
                        joursemaine.plageshoraires.remove(plagehoraire);
                    }
                }
            }

            return calendrier;
        }
    }
}
