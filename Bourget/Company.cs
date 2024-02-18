public class Company{
    private String SIRET;
    private String name;
    private Placement placement;
    private  List<Contact> contacts = [];


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
    public List<Contact> Contacts { get => contacts; }

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
        if(Program.CompaniesList.Count == 0) {
            Console.WriteLine("Il n'y a pas d'entreprise");
            Thread.Sleep(2000);
        }
        else
        {
            Console.WriteLine("SIRET\tNom\tHall\tParcelle\tSurface");
            foreach(Company C in Program.CompaniesList)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine(C.SIRET+"\t"+C.name+"\t"+C.placement.Hall +"\t"+ C.placement.Parcel+ "\t" + C.placement.Surface+" m²");
            }
            select = Console.ReadKey(true).KeyChar;
        }
    }
    private static void N() {
        Console.Write("Création d'un nouvel emplacement vide\nSIRET: ");
        string S = Console.ReadLine() ?? "";
        Console.Write("Nom: ");
        string N = Console.ReadLine() ?? "";
        if(Program.EmptyPlacements.Count != 0) {
            Console.WriteLine("1 - Créer un nouvel emplacement\n2 - Utiliser un emplacement libre");
            select = Console.ReadKey(true).KeyChar;
        }
        else
        {
            select = '1';
        }

        Placement P;

        E:

        switch (select)
        {
            case'1':
                P = Placement.N();
                break;
            case '2':
                Placement.L();
                Console.WriteLine("Séléctioner:");
                int No = Convert.ToInt32(Console.ReadLine() ?? "1");
                
                E2:

                if (No <= 0 || No > Program.EmptyPlacements.Count)
                {
                    Console.WriteLine("Valeur hors champ");
                    goto E2;
                }
                else
                {
                    P = Program.EmptyPlacements[No -1];
                    Program.EmptyPlacements.RemoveAt(No - 1);
                }
                break;
            default:
                Console.WriteLine("Commande inconue");
                goto E;

        }


        Program.CompaniesList.Add(new Company(S, N, P));

        while (!MExit)
        {
            Console.WriteLine("Ajouter un contact? (O/N)");
            select = Console.ReadKey(true).KeyChar;

            switch (select)
            {
                case 'o' or 'O':
                    Program.CompaniesList.Last().contacts.Add(Contact.N());
                    break;
                case 'n' or 'N':
                    MExit = true;
                    break;
                default:
                    Console.WriteLine("Commande inconue");
                    break;

            }
            //select = null;
            
            
        }

        MExit = false;
    }
}