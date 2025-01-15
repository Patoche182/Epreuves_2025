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
        string alphabet = "";                       // Création d'une chaîne vide pour stocker l'alphabet

        // On stock le a dans une variable          // | DÉC | OCT | HEX | BIN	    | Symbole |	Numéro HTML | Description |
        int firstLetter = 97;                       // | 97  | 141 | 61  | 01100001 |   a	  |  &#97;	 	| a minuscule | => Table des codes ASCII

        // On stock le z dans une variable          // | DÉC | OCT | HEX | BIN	    | Symbole |	Numéro HTML | Description |
        int lastLetter = 122;                       // | 122 | 172 | 7A  | 01111010 |	z     |	 &#122;     | z minuscule | => Table des codes ASCII

        for (int i = firstLetter; i <= lastLetter; i++) // Utilisation d'une boucle pour concaténer les lettres à la chaîne alphabet
        {
            alphabet += (char)i;                    // Incrémentation de la variable alphabet
        }
        Console.WriteLine(alphabet);                // Affichage de l'alphabet sur une seule ligne
    }
}