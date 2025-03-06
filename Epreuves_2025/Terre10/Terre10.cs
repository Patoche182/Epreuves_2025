/* 10 - NOMBRE PREMIER - 10

Créez un programme qui affiche si un nombre est premier ou pas.
Exemples d’utilisation :
    $> node exo.js 5
    Oui, 5 est un nombre premier.
    $> node exo.js 6
    Non, 6 n’est pas un nombre premier.

Attention : 0 et 1 ne sont pas des nombres premiers. Gérez les erreurs d’arguments.
 */

class Terre10
{
    static void Main() 
    {
        do
        {
            Console.WriteLine("Veuillez entrer un nombre entier positif (ou 'exit' pour quitter) :");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            if (int.TryParse(input, out int number) && number > 0)
            {
                bool isPrime = EstNombrePremier(number);

                if (isPrime)
                {
                    Console.WriteLine($"Ouiiiiiiii, {number} est un nombre premier. Bravo !");
                }
                else
                {
                    Console.WriteLine($"Non, {number} n'est pas un nombre premier.");
                }
            }
            else
            {
                Console.WriteLine("/!\\ Vous n'avez pas entrer un nombre valide...");
            }
            Console.WriteLine("----------=----------=----------=----------=----------");
        } while (true);
    }

    // Méthode :
    static bool EstNombrePremier(int n) 
    {
        if (n <= 1)
        {
            // 0 et 1 ne sont pas des nombres premiers
            return false;
        }
        // Vérifier si n est divisible par un nombre de 2 à la racine carrée de n
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                // n est divisible par i, donc ce n'est pas un nombre premier
                return false;
            }
        }
        // Si aucun diviseur n'est trouvé, n est un nombre premier
        return true;
    }
}