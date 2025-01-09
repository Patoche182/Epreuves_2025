/* 01 - NOM DU PROGRAMME - 01

Créez un programme qui affiche son nom de fichier.
Exemples d’utilisation :
    $> node exo.js
    exo.js
    $> node crevette.js
    crevette.js

|||||||||||||||||||||||| Objectif : apprendre comment récupérer le chemin de la localisation d'un fichier et le formater (en utilisant Assembly.Get) ||||||||||||||||||||||||
*/

using System.Reflection;

class Terre01
{
    static void Main(string[] args)
    {
        string cheminExecutable = Assembly.GetExecutingAssembly().Location;     //Assembly.GetExecutingAssembly().Location récupère le chemin d'accès complet du fichier exécutable (.exe) de l'application en cours d'exécution.
        string cheminSource = Path.ChangeExtension(cheminExecutable, ".cs");    //Path.ChangeExtension(cheminExecutable, ".cs") modifie l'extension du chemin récupéré pour obtenir le chemin d'accès complet du fichier source(.cs) correspondant à l'exécutable.
        string fichierSource = Path.GetFileName(cheminSource);                  //Path.GetFileName(cheminSource) extrait le nom du fichier source à partir du chemin complet du fichier source.
        Console.WriteLine(fichierSource);                                       //Console.WriteLine(fichierSource) affiche le nom du fichier source sur la console.
    }
}