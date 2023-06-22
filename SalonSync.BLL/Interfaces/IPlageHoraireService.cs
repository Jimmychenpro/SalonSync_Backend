using SalonSync.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonSync.BLL.Interfaces
{
    public interface IPlageHoraireService
    {
        List<PlageHoraire> GetPlagesHoraires();
        List<PlageHoraire> GetPlagesHorairesByCoiffeurId(int coiffeurId);
    }
}
