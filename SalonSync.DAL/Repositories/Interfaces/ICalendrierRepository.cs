using SalonSync.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonSync.DAL.Repositories.Interfaces
{
    public interface ICalendrierRepository
    {
        public List<Calendrier> GetAllCalendrier();
    }
}
