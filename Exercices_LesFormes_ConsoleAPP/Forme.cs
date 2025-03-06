using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices_LesFormes_ConsoleAPP
{
    public abstract class Forme
    {
        public string Nom { get; set; } = "Forme";
        public List<FormePoint>? ListePoints { get; set; }
        public FormePoint? Centre => CalculCentreForme();
        public double Aire => CalculAire();
        public double Perimetre => CalculPerimetre();
        public Forme(string nom)
        {
            Nom = nom;
        }
        public Forme(string nom, List<FormePoint> listePoints)
        {
            Nom = nom;
            ListePoints = listePoints;
        }
        public override string ToString()
        {
            return $"-------------------------------------------------------------------\n" +
                   $"Nom: {Nom}\n" +
                   $"Aire: {Aire} unité(s) carrée\n" +
                   $"Perimetre: {Perimetre} unité(s)\n" +
                   $"Centre: P({Centre.X}, {Centre.Y})\n" +
                   $"{Afficher()}\n"+
                $"-------------------------------------------------------------------\n";
        }
        public abstract double CalculAire();
        public abstract double CalculPerimetre();
        public abstract string Afficher();
        public virtual FormePoint? CalculCentreForme() 
        {
            if (ListePoints == null) return null;
            FormePoint centre = new FormePoint(0, 0);
            foreach (FormePoint p in ListePoints)
            {
                centre.X += p.X;
                centre.Y += p.Y;
            }
            centre.X /= ListePoints.Count;
            centre.Y /= ListePoints.Count;
            return centre; 
        }
    }
}
