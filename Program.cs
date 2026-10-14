namespace PairImpairBoucle;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consignes
         * Demandez à l'utilisateur un nombre
         * Dites à l'utilisateur si le nombre fourni est pair ou impair
         * Demandez à l'utilisateur s'il veut proposer un autre nombre
         *  On lui permet de le faire lorsqu'il entre "y". Dans les autres cas, on termine le programme
         */
        int nombre;
        string reponse;
        do
        {
            Console.WriteLine("Donne moi un nombre");
            nombre = Convert.ToInt32(Console.ReadLine());
            if (nombre % 2 == 0)
            {
                Console.WriteLine("Ton nombre est pair");
            }
            else
            {
                Console.WriteLine("Ton nombre est impair");
            }
            Console.WriteLine("Voulez-vous refaire le script ? y/n");
            reponse = Console.ReadLine();
        } while (reponse == "y");
    }
}
