/* 05 - DIVISIONS - 05

Créez un programme qui affiche le résultat et le reste d’une division entre deux nombres.
Exemples d’utilisation :
    $> python exo.py 5 2
    résultat: 2
    reste: 1
    $> python exo.py 10 0
    erreur.
    $> python exo.py 3 5
    erreur.
*/

class Terre05
{
    static void Main()
    {
        do
        {
            Console.WriteLine("Donne-moi un nombre que tu souhaite diviser (ou 'exit' pour quitter) :");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Maintenant, par quelle valeur souhaite-tu le diviser (ou 'exit' pour quitter) :");
            int b = Convert.ToInt32(Console.ReadLine());

            if (b != 0)     // le deuxième nombre doit être différent de zéro avant de continuer
            {
                Console.WriteLine("Le résultat de la division est " + Division(a, b) + ". Le reste est de " + Reste(a, b));
            }
            else
            {
                Console.WriteLine("Attention, la division par zéro est impossible!");
            }
            Console.WriteLine("----------=----------=----------=----------=----------");
        } while (true);
    }

    static int Division(int a, int b) 
    {
        int resultat = a / b;
        return resultat;
    }

    static int Reste(int a, int b) 
    {
        int reste = a % b;
        return reste;
    }
}