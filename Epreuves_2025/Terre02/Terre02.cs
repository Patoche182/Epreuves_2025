/* 02 - AFFICHEUR D'ARGUMENTS - 02

Créez un programme qui affiche les arguments qu’il reçoit ligne par ligne, peu importe le nombre d’arguments.
Exemples d’utilisation :
    $> ruby exo.rb je suis solide !
    je
    suis
    solide
    !
*/

class Terre02
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Aucun argument n'a été fourni.");
        }
        else
        {
            GetArgs(args);
        }
    }

    static void GetArgs(string[] args)
    {
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine(args[i]);
        }
    }
}


// Methode 2:
//do
//{
//    Console.WriteLine("Veuillez entrer une phrase, ex : je suis solide ! (ou 'exit' pour quitter) :");
//    string input = Console.ReadLine();
//    if (input.ToLower() == "exit")
//        break;
//    string[] phraseInput = { input };
//    ConvertirPhrase(phraseInput);
//} while (true);
//    }

//    static void ConvertirPhrase(string[] phraseInput)
//{
//    for (int mot = 0; mot < phraseInput.Length; mot++)
//    {
//        string[] splitPhraseInput = phraseInput[mot].Split(' ');        // On utilise la méthode Split pour diviser la chaîne par les espaces

//        for (int mots = 0; mots < splitPhraseInput.Length; mots++)      // On affiche chaque élément de la chaîne divisée ligne par ligne
//        {
//            Console.WriteLine(splitPhraseInput[mots].Trim());           // On utilise Trim pour supprimer les espaces autour des mots
//        }
//    }
//    Console.WriteLine();