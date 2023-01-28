using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yummy.Models
{
    public class IdeasSearch
    {
        public int Id { get; set; }
        public string Naslov { get; set; }
        public string KratkiOpis { get; set; }
        public string Slika { get; set; }
        public string DugiOpis { get; set; }
        public string Instrukcije { get; set; }
    }
}
