using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices_LesFormes_ConsoleAPP
{
    public class Cercle
    {
        public FormePoint Centre { get; set; }
        public double Rayon { get; set; }
        public Cercle(FormePoint centre, double rayon)
        {
            Centre = centre;
            Rayon = rayon;
        }
        public double Perimetre()
        {
            return 2 * Math.PI * Rayon;
        }
        public double Aire()
        {
            return Math.PI * Math.Pow(Rayon, 2);
        }
        public bool EstInterieur(FormePoint p)
        {
            return Centre.Distance(p) < Rayon;
        }
        // Vérifie si le point est sur l'arc du cercle même.
        public bool Inclus(FormePoint p)
        {
            return Centre.Distance(p) == Rayon;
        }
        public override string ToString()
        {
            return $"Cercle de centre {Centre} et de rayon {Rayon} unité(s)\n" +
                $"Circonférence: {Perimetre()} unité(s), Aire: {Aire()} unité(s) carrée(s)\n";
        }
    }
}
