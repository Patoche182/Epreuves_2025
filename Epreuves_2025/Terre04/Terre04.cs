﻿/* 04 - PAIR OU IMPAIR - 04

Créez un programme qui permet de déterminer si l’argument donné est un entier pair ou impair..
Exemples d’utilisation :
    $> ruby exo.rb 2
    pair
    $> ruby exo.rb 5
    impair
    $> ruby exo.rb Bonjour
    Tu ne me la mettras pas à l’envers.
    $> ruby exo.rb
    Tu ne me la mettras pas à l’envers.
Attention : gérez aussi les entiers négatifs.
Fonctions interdites: 
-En Ruby: even? et odd ?
*/

class Terre04
{
    static void Main()
    {
        do
        {
            Console.WriteLine("Donne-moi un chiffre (ou 'exit' pour quitter) :");
            string response = Console.ReadLine();
            int x;
            if (int.TryParse(response, out x))
            {
                Console.WriteLine("C'est un " + PairOuImpair(x) + " - " + PositifOuNegatif(x));
            }
            else
            {
                Console.WriteLine("Tu ne me la mettras pas à l'envers.");
            }
            Console.WriteLine("----------=----------=----------=----------=----------");
        } while (true);
    }

    static string PairOuImpair(int nombre)
    {
        if (nombre % 2 == 0) // On vérifie si le modulo de 2 de ce chiffre est égal à 0 (10/2 = 5 reste 0). Dans ce cas, il est Pair.
        {
            return " Pair ";
        }
        else
        {
            return " Impair ";
        }
    }

    static string PositifOuNegatif(int nombre)
    {
        if (nombre > 0)
        {
            return " Positif ";
        }
        else if (nombre < 0)
        {
            return " Négatif ";
        }
        else
        {
            return "Zéro || 0 est bien Pair mais il n'est ni Positif ni Négatif !";
        }
    }
}