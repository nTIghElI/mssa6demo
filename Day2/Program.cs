namespace Day2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        string[,] corporate =
        {
            {"Robert", "Bavin"}, {"Simon", "Bright"},
            {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
            {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
        };

        string[,] external =
        {
            {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
            {"Shay", "Lawrence"}, {"Daren", "Valdes"}
        };

        string externalDomain = "hayworth.com";

        for (int i = 0; i < corporate.GetLength(0); i++)
        {
            // display internal email addresses
            DisplayEmail(first: corporate[i, 0], last: corporate[i, 1]);


        }

        for (int i = 0; i < external.GetLength(0); i++)
        {
            // display external email addresses 
            DisplayEmail(first: external[i, 0], last: external[i, 1], domain: externalDomain);
        }


        // robavin@contoso.com
        // sibright@contoso.com
        // kisinclair@contoso.com
        // aakamath@contoso.com
        // sadelucchi@contoso.com
        // siali@contoso.com
        // viashton@hayworth.com
        // codysart@hayworth.com
        // shlawrence@hayworth.com
        // davaldes@hayworth.com
    }

    public static void DisplayEmail(string first, string last, string domain = "contoso.com")
    {
        string email = first.Substring(0, 2) + last;
        email = email.ToLower();
        System.Console.WriteLine($"{email}@{domain}");
    }
}


