using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SalonSync.DAL.Entities
{
    public class Calendrier
    {
        public TimeSpan Lundi { get; set; }
        public TimeSpan Mardi { get; set; }
        public TimeSpan Mercredi { get; set; }
        public TimeSpan Jeudi { get; set; }
        public TimeSpan Vendredi { get; set; }
        public TimeSpan Samedi { get; set; }
        public TimeSpan Dimanche { get; set; }

    }
}
