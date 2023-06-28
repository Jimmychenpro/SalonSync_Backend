using SalonSync.DAL.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonSync.DAL.Repositories.Interfaces
{
    public interface ICoiffeurRepository
    {
        List<CoiffeurDTO> GetCoiffeurById(int idCoiffeur);
        List<CoiffeurDTO> GetAllCoiffeur();
    }
}
