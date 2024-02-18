public class Contact{
    private String name;
    private String phone;
    private String email;

    public Contact(string name, string phone, string email)
    {
        this.name = name;
        this.phone = phone;
        this.email = email;
    }

    public string Name { get => name; set => name = value; }
    public string Phone { get => phone; set => phone = value; }
    public string Email { get => email; set => email = value; }

    public static Contact N()
    {
        Console.Write("Nom du contact: ");
        String N = Console.ReadLine() ?? "";
        Console.Write("N° de téléphone: ");
        String P = Console.ReadLine() ?? "";
        E3:
        Console.Write("Email: ");
        String E = Console.ReadLine() ?? "";

        if (!E.Contains('.') && !E.Contains('@')) {
            Console.WriteLine("Email invalide");
            goto E3;
        }

        return new Contact(N, P, E);
    }
}