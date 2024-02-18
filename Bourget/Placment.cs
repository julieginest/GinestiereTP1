using static System.Net.Mime.MediaTypeNames;

public class Placement{
    public string hall;
    public string parcel;
    public double surface;
    static bool MExit = false;
    static char select;

    public Placement(string hall, string parcel, double surface)
    {
        this.hall = hall;
        this.parcel = parcel;
        this.surface = surface;
    }

    public string Hall { get => hall; set => hall = value; }
    public string Parcel { get => parcel; set => parcel = value; }
    public double Surface { get => surface; set => surface = value; }

    public static void M()
    {
        while (!MExit)
        {

            Console.Clear();
            Console.WriteLine("Emplacement");
            Console.WriteLine("1 - Lister/Modifier les emplacments libres");
            Console.WriteLine("2 - Créer un nouvel emplacement");

            select = Console.ReadKey(true).KeyChar;

            switch (select)
            {
                case '1':
                    L();
                    break;
                case '2':
                    Program.EmptyPlacements.Add(N());
                    break;
                case 'e' or 'E':
                    MExit = true;
                    break;
                default:
                    Console.WriteLine("Commande inconue");
                    break;

            }
        }
        MExit = false;
    }
    public static void L()
    {
        if (Program.EmptyPlacements.Count > 0)
        {
            Console.WriteLine("Hall\tParcel\tSurface");
            foreach (Placement P in Program.EmptyPlacements)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine(P.hall + "\t" + P.parcel + "\t" + P.surface + " m²");
            }
        select = Console.ReadKey(true).KeyChar;
        }
        else
        {
            Console.WriteLine("Il n'y a pas d'emplacement vides");
            Thread.Sleep(2000);
        }
    }
    public static Placement N()
    {
        Console.Write("Création d'un nouvel emplacement\nHall:");
        string H = Console.ReadLine() ?? "";
        Console.Write("N° d'emplacement:");
        string N = Console.ReadLine() ?? "";
        Console.Write("Surface:");
        Double S = Convert.ToDouble(Console.ReadLine() ?? "0");

        return new Placement(H, N, S);
    }

}