using ElChapo.Catch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElChapo.Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Catcheur> catcheurs = new List<Catcheur>();
            
            IEnumerable<Catcheur> disponibles = catcheurs.Where(c => c.Etat == EtatEnum.Disponible).OrderBy(c => c.Name);

            Console.ReadLine();
        }

        static void MaFonction(Catcheur catcheur, int t)
        {
            catcheur.Name = "toto";
            t = 10;
        }
    }
}
