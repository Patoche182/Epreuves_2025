/* 01 - NOM DU PROGRAMME - 01

Créez un programme qui affiche son nom de fichier.
Exemples d’utilisation :
    $> node exo.js
    exo.js
    $> node crevette.js
    crevette.js
*/

using System.Diagnostics;
using System.Reflection;

class Terre01
{
    static void Main(string[] args)
    {
        //Methode 0 : 
        Console.WriteLine(AppDomain.CurrentDomain.FriendlyName + ".cs");

        // Methode 1 :
        string path = Process.GetCurrentProcess().MainModule.FileName;              //Obtenir le chemin d'accès complet du programme en cours d'exécution 
        string file = System.IO.Path.GetFileName(path);                             //Extraire le nom du fichier à partir du chemin complet 
        Console.WriteLine(file);                                                    //Afficher le nom du fichier 

        // Methode 2 :
        string executablePath = Assembly.GetExecutingAssembly().Location;           // récupère le chemin d'accès complet du fichier exécutable (.exe) de l'application en cours d'exécution.
        string[] segments = executablePath.Split(Path.DirectorySeparatorChar);      // Séparer les segments du chemin avec Path.DirectorySeparatorChar 

        // Methode 3 :
        string lastSegment = segments.Last();                                       // Utilise .Last() 
        Console.WriteLine(lastSegment);

        // Methode 4 :
        string lastSegmentIndex = segments[^1];                                     // Utilise l'indexation de fin  
        Console.WriteLine(lastSegmentIndex);

        // Methode attendu ?
        string pathProgram = Process.GetCurrentProcess().MainModule.FileName;
        Console.WriteLine(pathProgram);
        string[] iteration = pathProgram.Split("\\");                               // On sépare par l'antiSlash "\" (qu'on échap ici => "\\") 
        string lastIteration = iteration.Last();
        Console.WriteLine(iteration[5]);                                            // Exemple pour récupérer un index quelconque  
        Console.WriteLine(lastIteration);
        string programName = lastIteration.Replace(".exe", ".cs");                  // On remplace le .exe par .cs pour convenir à l'énoncé ... 
        Console.WriteLine(programName);
    }
}








// Methode 1:
//    Console.WriteLine($"Le nom du programme est : {AppDomain.CurrentDomain.FriendlyName}" + ".cs");
//    Console.WriteLine("----------");

// Methode 2:
//    string filePath = @"C:\Users\patri\source\repos\CodingAccelerator\Terre01.cs";
//    string fileName = Path.GetFileName(filePath);
//    Console.WriteLine("Nom du fichier : " + fileName);

// Methode 3:
//static void Main(string[] args)
//    // Vérifier si des arguments ont été passés en ligne de commande
//    if (args.Length > 0)
//    {
//        // Si oui, afficher le nom du premier fichier passé en argument
//        string fichier = System.IO.Path.GetFileName(args[0]);
//        Console.WriteLine(fichier);
//    }
//    else
//    {
//        // Si aucun argument n'est passé, afficher un message d'erreur
//        Console.WriteLine("Aucun fichier spécifié en argument.");
//    }