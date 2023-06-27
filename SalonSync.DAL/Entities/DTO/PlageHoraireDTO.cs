using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonSync.DAL.Entities.DTO
{
    public class PlageHoraireDTO
    {
        public DateTime PlageHoraireDate { get; set; }
        public TimeSpan HeureDebut { get; set; }
    }
}
