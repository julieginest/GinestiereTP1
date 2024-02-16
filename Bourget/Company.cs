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
    private static void L() { }
    private static void N() { }
}