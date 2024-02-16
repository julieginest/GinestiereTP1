public class Company{
    private String SIRET;
    private String name;
    private Placement placement;
    private  List<Contact> contacts;
    static bool MExit = false;
    static char select;

    public Company(string sIRET, string name, Placement placement)
    {
        SIRET = sIRET;
        this.name = name;
        this.placement = placement;
    }

    public string Siret { get => SIRET; set => SIRET = value; }
    public string Name { get => name; set => name = value; }
    public Placement Placement { get => placement; set => placement = value; }
    public List<Contact> Contacts { get => contacts; set => contacts = value; }

    public static void M() {
        while (!MExit)
        {
            Console.Clear();
            Console.WriteLine("Entreprises");
            Console.WriteLine("1 - Lister/Modifier les entreprises");
            Console.WriteLine("2 - Inviter une nouvelle entreprise");

            select = Console.ReadKey(true).KeyChar;

            switch (select)
            {
                case '1':
                    L();
                    break;
                case '2':
                    N();
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
    private static void L() {
            Console.WriteLine("SIRET\tNom\tHall\tParcelle\tSurface");
        foreach(Company C in Program.CompaniesList)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine(C.SIRET+"\t"+C.name+"\t"+C.placement.Hall +"\t"+ C.placement.Parcel+ "\t" + C.placement.Surface+" m²");
        }
        select = Console.ReadKey(true).KeyChar;
    }
    private static void N() {
        Console.Write("Création d'un nouvel emplacement vide\nSIRET: ");
        string S = Console.ReadLine() ?? "";
        Console.Write("Nom: ");
        string N = Console.ReadLine() ?? "";
        Placement P = Placement.N();

        Program.CompaniesList.Add(new Company(S, N, P));
    }
}