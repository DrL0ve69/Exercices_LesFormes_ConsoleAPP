using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices_LesFormes_ConsoleAPP
{
    public class Rectangle : Forme
    {
        public double Largeur { get; set; }
        public double Longueur { get; set; }
        public Rectangle(string nom, List<FormePoint> listePoints) : base(nom, listePoints)
        {
            if(listePoints.Count < 2 || listePoints.Count > 4) throw new ArgumentException("Le rectangle doit être défini par au moins 2 points et maximum 4");
            // Définition de la largeur et de la longueur si 2 point, assumé qu'ils sont en diagonale
            Largeur = listePoints[1].X - listePoints[0].X;
            Longueur = listePoints[1].Y - listePoints[0].Y;
            // si 3 points et 4 points à faire
        }
        public Rectangle(string nom, List<FormePoint> listePoints, double largeur, double longueur) : base(nom, listePoints)
        {
            if(listePoints.Count > 1) throw new ArgumentException("Le rectangle doit être défini par un seul point");
            Largeur = largeur;
            Longueur = longueur;
        }
        public Rectangle(string nom, double largeur, double longueur) : base(nom)
        {
            Largeur = largeur;
            Longueur = longueur;
            ListePoints = new List<FormePoint> 
            {
                new FormePoint(0, 0),
                new FormePoint(Longueur, 0),
                new FormePoint(0, Largeur),
                new FormePoint(Longueur, Largeur)
            };
        }
        public override string Afficher()
        {
            string strBuilder = "";
            // Double loop pour dessiner le rectangle
            for (int i = 0; i < Largeur; i++)
            {
                for (int j = 0; j < Longueur; j++)
                {
                    strBuilder += "*";
                }

                strBuilder += "\n";
            }
            return strBuilder;
        }

        public override double CalculAire()
        {
            return Largeur * Longueur;
        }

        public override double CalculPerimetre()
        {
            return 2 * (Largeur + Longueur);
        }
    }
}
