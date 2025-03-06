/* 14 - Trié ou pas - 14

Créez un programme qui détermine si une liste d’entiers est triée ou pas.
Exemples d’utilisation :
    $> ruby exo.rb 9 8 3
    Pas triée !
    $> ruby exo.rb 3 8 9 12
    Triée !
    $> ruby exo.rb “Salut”
    erreur.

Fonctions interdites: 
-La fonction sort
*/

class Terre14
{
    static void Main()
    { bool continuer = true;
        do
        {
            Console.WriteLine("Veuillez entrer une liste de nombres entiers séparés par un espace (ou 'exit' pour quitter) :");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                break;
            }
            string[] numbersString = input.Split(' ');

            // Convertir les chaînes en nombres entiers
            int[] numbers = new int[numbersString.Length];
            for (int i = 0; i < numbersString.Length; i++)
            {
                if (!int.TryParse(numbersString[i], out numbers[i]))
                {
                    Console.WriteLine("Erreur : Veuillez entrer des nombres entiers valides.");
                    continuer = false;
                    break;
                }
            }
            if (!continuer)
            {
                continue;
            }

            bool sorted = true;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    sorted = false;
                    break;
                }
            }

            if (sorted)
            {
                Console.WriteLine("Les nombres sont triés.");
            }
            else
            {
                Console.WriteLine("Les nombres ne sont pas triés.");
            }
        } while (continuer);
    }
}