using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElChapo.Catch.Models
{
    enum EtatEnum
    {
        Disponible,
        Convalescence,
        Mort
    }

    class Catcheur
    {
        public String Name { get; set; }
        public EtatEnum Etat { get; set; }
    }
}
