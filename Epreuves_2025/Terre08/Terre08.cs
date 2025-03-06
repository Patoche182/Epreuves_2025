/* 08 - PUISSANCE D'UN NOMBRE - 08

Créez un programme qui affiche le résultat d’une puissance.
L’exposant ne pourra pas être négatif.
Exemples d’utilisation :
    $> node exo.js 2 3
    8
Attention : je compte sur vous pour gérer les potentielles erreurs d’arguments.
Fonctions interdites: 
-La fonction pow

 */

class Terre08
{
    static void Main() 
    {
        do
        {
            Console.WriteLine("Veuillez entrer un NOMBRE : (ou 'exit' pour quitter)");
            string baseNumberInput = Console.ReadLine();

            if (baseNumberInput.ToLower() == "exit")
                break;

            if (double.TryParse(baseNumberInput, out double baseNumber))
            {
                // On définie l'EXPOSANT
                Console.WriteLine("Veuillez entrer un EXPOSANT : (ou 'exit' pour quitter)");
                string exponentInput = Console.ReadLine();

                if (exponentInput.ToLower() == "exit")
                    break;

                if (int.TryParse(exponentInput, out int exponent))
                {
                    Console.WriteLine("Le résultat du calcul de puissance est : " + Puissance(baseNumber, exponent));
                }
                else
                {
                    Console.WriteLine("Attention ! Vous n'avez pas entrer un exposant valide... Concentrez-vous ! \n||||||||||||||| On recommence : |||||||||||||||");
                }
            }
            else
            {
                Console.WriteLine("Attention ! Vous n'avez pas entrer un nombre Valide... Pas de blagues !");
            }
            Console.WriteLine("----------=----------=----------=----------=----------");
        } while (true);
    }

    // Méthodes :
    static double Puissance(double baseNumber, int exponent) 
    {
        double result = 1;
        for (int i = 0; i < exponent; i++)
        {
            result *= baseNumber;
        }
        return result;
    }
}