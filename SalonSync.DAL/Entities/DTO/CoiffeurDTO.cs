using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonSync.DAL.Entities.DTO
{
    public class CoiffeurDTO
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Rue { get; set; }
        public string Ville { get; set; }
        public string Cp { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
    }
}
