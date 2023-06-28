using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonSync.DAL.Entities
{
    public class Calendrier
    {
        public int Id { get; set; }
        public DateTime PlageHoraireDate { get; set; }
        public TimeSpan HeureDebut { get; set; }
        public TimeSpan HeureFin { get; set; }
        public bool EstDisponible { get; set; }
    }
}
