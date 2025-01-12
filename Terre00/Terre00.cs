/* 00 - L’ALPHABET - 00

Créez un programme qui affiche l’alphabet en lettres minuscules suivi d’un retour à la ligne.
Exemples d’utilisation :
    $> python exo.py
    abcdefghijklmnopqrstuvwxyz
    $>
Attention : votre programme devra utiliser une boucle. 
*/


class Terre00
{
    static void Main()
    {
        string alphabet = "";                   // Création d'une chaîne pour stocker l'alphabet

        for (int i = 97; i <= 122; i++)         // Utilisation d'une boucle pour concaténer les lettres à la chaîne alphabet
        {
            alphabet += (char)i;                // Incrémentation de la variable alphabet
        }
        Console.WriteLine(alphabet);            // Affichage de l'alphabet sur une seule ligne
    }
}