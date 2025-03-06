/* 07 - TAILLE D'UNE CHAINE - 07

Créez un programme qui affiche le nombre de caractères d’une chaîne de caractères passée en argument.
Exemples d’utilisation :
    $> python exo.py “Hello world!”
    12
    $> python exo.py
    erreur.
    $> python exo.py “Bonjour” “Aurevoir”
    erreur.
    $> python exo.py 10
    erreur.

Fonctions interdites: 
-La fonction length
-La fonction size
 */

class Terre07
{
    static void Main() 
    {
        do
        {
            Console.WriteLine("Veuillez entrer une chaîne de caractère. (ou 'exit' pour quitter) :");
            string userInput = Console.ReadLine();
            string chaine = userInput;

            if (chaine == "exit")
                break;

            if (chaine != "") 
            {
                Console.WriteLine("La chaîne contient - " + Taille(chaine) + " - caractères.");
            }
            else
            {
                Console.WriteLine("Attention, vous n'avez pas entré une chaine valide. \nEcrivez un mot, une phrase, un code à chiffres, etc ...");
            }
            Console.WriteLine("----------=----------=----------=----------=----------");
        } while (true);
    }

    // Méthodes :
    static string Taille(string chaine)
    {
        int count = 0;                      // on initialise notre variable Count à zéro
        foreach (char lettre in chaine)     // pour chaque lettre, et espace, dans notre chaine on ajoute +1 à notre variable count
        {
            count++;
        }
        return count.ToString(); // on renvoie la valeur final de count dans en string
    }
}