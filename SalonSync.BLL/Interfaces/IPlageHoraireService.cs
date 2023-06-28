using SalonSync.DAL.Entities;
using SalonSync.DAL.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonSync.BLL.Interfaces
{
    public interface IPlageHoraireService 
    {
        List<PlageHoraireDTO> GetPlageHorairesByCoiffeur(int coiffeurId);
    }
}
