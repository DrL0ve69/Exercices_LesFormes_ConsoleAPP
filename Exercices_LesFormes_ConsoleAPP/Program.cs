using Exercices_LesFormes_ConsoleAPP;
using System.Globalization;

Console.WriteLine("Application console pour les formes\n_____________________________________________________________");

/*
Rectangle rectangle1 = new Rectangle("Rectangle 1", new List<FormePoint> { new FormePoint(0, 0) }, 2, 5); // Arrange le constructeur
Console.WriteLine(rectangle1);

Rectangle rectangle2 = new Rectangle("Rectangle 2", 6, 3);
Console.WriteLine(rectangle2);

Cercle cercle1 = new Cercle(new FormePoint(0, 0), 5);
Console.WriteLine(cercle1);
Console.WriteLine(cercle1.Inclus(new FormePoint(0,-5)));

Cercle cercle2 = new Cercle(new FormePoint(-6.6, 6), 10);
Console.WriteLine(cercle2);

*/

/*
 * 3-	Écrivez un programme de test qui :
•	Demande à l’utilisateur d’entrer les valeurs du centre du cercle ainsi que son rayon.
•	Affiche les valeurs entrées moyennant la méthode d’affichage du cercle.
•	Affiche ensuite le périmètre et la surface du cercle.
•	Demande à l’utilisateur d’entrer un point p et appelle la méthode Inclus () pour vérifier s’il appartient au cercle ou pas et affiche un message en conséquence.
 */

// Étape 1: Demande à l’utilisateur d’entrer les valeurs du centre du cercle ainsi que son rayon.
try 
{
    Console.WriteLine("Entrez la valeur du X pour le centre du cercle:");
    double x = double.Parse(Console.ReadLine());
    Console.WriteLine("Entrez la valeur du Y pour le centre du cercle:");
    double y = double.Parse(Console.ReadLine());
    Console.WriteLine("Entrez la valeur du rayon du cercle:");
    double rayon = double.Parse(Console.ReadLine());

    // Étape 2: Affiche les valeurs entrées moyennant la méthode d’affichage du cercle.
    // Étape 3: Affiche ensuite le périmètre et la surface du cercle.
    Cercle cercle = new Cercle(new FormePoint(x, y), rayon);
    Console.WriteLine(cercle);

    // Étape 4: Demande à l’utilisateur d’entrer un point p, retour booléen si le point est inclus sur l'arc du cercle.
    Console.WriteLine("Entrez la valeur du X, pour savoir si le point est inclu sur l'arc du cercle:");
    double xPoint = double.Parse(Console.ReadLine()); // CultureInfo.InvariantCulture
    Console.WriteLine("... Et puis son Y:");
    double yPoint = double.Parse(Console.ReadLine());
    FormePoint point = new FormePoint(xPoint, yPoint);
    Console.WriteLine($"Vôtre point : {point}" + "Se retrouve sur l'arc du cercle? " + cercle.Inclus(point));
}
catch (Exception ex)
{
    Console.WriteLine("Tu as tout boussillé connard!\n" + ex.Message);
}