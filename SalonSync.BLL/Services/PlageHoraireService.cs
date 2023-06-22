using SalonSync.BLL.Interfaces;
using SalonSync.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonSync.BLL.Services
{
    public class PlageHoraireService : IPlageHoraireService
    {

        public List<PlageHoraire> GetPlagesHoraires()
        {
            List<PlageHoraire> plagesHoraires = new List<PlageHoraire>();

            TimeSpan heureDebut = new TimeSpan(8, 0, 0); // 08:00
            TimeSpan heureFin = new TimeSpan(20, 0, 0); // 20:00
            TimeSpan pas = new TimeSpan(0, 30, 0); // Pas de 30 minutes

            while (heureDebut < heureFin)
            {
                PlageHoraire plageHoraire = new PlageHoraire
                {
                    HeureDebut = heureDebut,
                    HeureFin = heureDebut.Add(pas)
                };

                plagesHoraires.Add(plageHoraire);

                heureDebut = heureDebut.Add(pas);
            }

            return plagesHoraires;
        }

        public List<PlageHoraire> GetPlagesHorairesByCoiffeurId(int coiffeurId)
        {
            throw new NotImplementedException();
        }
    }
}
