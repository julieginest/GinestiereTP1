class Program
{
    public static bool MExit = false;
    public static char select;
    public static List<Company> CompaniesList = [];
    public static List<Placement> EmptyPlacements = [];









    static void Main(string[] args)
    {
        while (!MExit)
        {
            Console.Clear();
            Console.WriteLine("#########################");
            Console.WriteLine("#########BourGère########");
            Console.WriteLine("#########################");
            Console.WriteLine("1 - Entreprises");
            Console.WriteLine("2 - Emplacement");
            Console.WriteLine("E - Quitter l'application");

            select = Console.ReadKey(true).KeyChar;

            switch (select)
            {
                case '1':
                    Company.M();
                    break;
                case '2':
                    Placement.M(); ;
                    break;
                case 'E' or 'e':
                    Console.WriteLine("Au revoir");
                    MExit = true;
                    break;
                default:
                    Console.WriteLine("Commande inconu");
                    break;
            }


        }
    }
}