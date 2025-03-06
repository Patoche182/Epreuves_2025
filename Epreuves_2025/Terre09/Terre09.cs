/* 09 - RACINE CARRE D'UN NOMBRE - 09

Créez un programme qui affiche la racine carrée d’un entier positif.
Exemples d’utilisation :
    $> node exo.js 9
    3
Attention : je compte sur vous pour gérer les potentielles erreurs d’arguments.
Fonctions interdites: 
-La fonction sqrt
 */

class Terre09
{
    static void Main()
    {
        do
        {
            Console.WriteLine("Veuillez entrer un nombre : (ou 'exit' pour quitter)");
            string baseNumberInput = Console.ReadLine();

            if (baseNumberInput.ToLower() == "exit")
                break;

            if (double.TryParse(baseNumberInput, out double baseNumber) && baseNumber > 0)
            {
                RacineCarre((int)baseNumber);
            }
            else
            {
                Console.WriteLine("- /!\\ /!\\ Attention ! Veuillez entrer un nombre ENTIER et POSITIF svp /!\\ /!\\ -");
            }
            Console.WriteLine("----------=----------=----------=----------=----------");

        } while (true);
    }

    // Méthodes :
    static double RacineCarre(int baseNumber) 
    {
        double result = Math.Pow(baseNumber, 0.5); // 0.5 et non pas 0,5 !

        if (result % 1 == 0)
        {
            Console.WriteLine("Le résultat du calcul de la Racine Carré est : " + result.ToString("F0")); // pour afficher le résultat sans décimal
        }
        else
        {
            Console.WriteLine("Le résultat du calcul de la Racine Carré est : " + result.ToString("F2")); // pour afficher le résultat avec 2 décimals
        }
        return result;
        // return (int)result;
    }
}