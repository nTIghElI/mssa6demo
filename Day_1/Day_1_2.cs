// class Program
// {
//     const decimal TaxRate = 0.075m;
//     static void Main()
//     {
//         var e1 = new Example();
//         var e2 = new Example();

//         Console.WriteLine($"e1.Id: {e1.Id}");
//         Console.WriteLine($"e2.Id: {e2.Id}");
//     }

// }

// public class Example
// {
//     public readonly Guid Id = Guid.NewGuid();

//     public Example()
//     {

//     }
// }

// class Program
// {
//     const decimal TaxRate = 0.075m;
//     static void Main()
//     {
//         var p1 = new PersonWithSet { Name = "Alice" };
//         Console.WriteLine(p1.Name);
//         p1.Name = "Karen";
//         Console.WriteLine(p1.Name);

//         var p2 = new PersonWithInit { Name = "Charlie" };
//         Console.WriteLine(p2.Name);
//         // p2.Name = "Dave"; this will not work
//         Console.WriteLine(p2.Name);
//     }

// }

// public class PersonWithSet
// {
//     public string Name { get; set; }
// }

// public class PersonWithInit
// {
//     public string Name { get; init; }
// }

// class Program
// {    static void Main()
//     {
//         int a = 3;
//         int b = 4;
//         int c = 0;

//         Multiply(a, b, c);
//         Console.WriteLine($"global statement: {a} x {b} = {c}");

//         void Multiply(int a, int b, int c)
//         {
//             c = a * b;
//             Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
//         }
//     }

// }

// class Program
// {    static void Main()
//     {
//         int a = 3;
//         int b = 4;
//         int c = 0;

//         Multiply(a, b, ref c);
//         Console.WriteLine($"global statement: {a} x {b} = {c}");

//         void Multiply(int a, int b, ref int c)
//         {
//             c = a * b;
//             Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
//         }
//     }

// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Box boxA = new Box(3);
//         Box boxB = new Box(4);
//         Box result = new Box(0);

//         Multiply(boxA, boxB, result);
//         Console.WriteLine($"global statement: {boxA.Value} x {boxB.Value} = {result.Value}");
//     }

//     static void Multiply(Box a, Box b, Box c)
//     {
//         c.Value = a.Value * b.Value;
//         Console.WriteLine($"inside Multiply method: {a.Value} x {b.Value} = {c.Value}");
//     }
// }

// class Box
// {
//     public int Value;
//     public Box(int value)
//     {
//         Value = value;
//     }
// }

// using System.Text;

// class Program
// {
//     static void Main()
//     {
//         StringBuilder sb = new StringBuilder();
//         Foo(sb);
//         Console.WriteLine(sb.ToString());
//     }

//     static void Foo(StringBuilder fooSB)
//     {
//         fooSB.Append("test");
//         fooSB = null;
//     }
// }

//Exercise - Methods with optional parameters
class Program
{
    static void Main()
    {


        string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
        string[] rsvps = new string[10];
        int count = 0;

        RSVP("Rebecca");
        RSVP("Nadia", 2, "Nuts");
        RSVP(name: "Linh", partySize: 2, inviteOnly: false);
        RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
        RSVP("Noor", 4, inviteOnly: false);
        RSVP("Jonte", 2, "Stone fruit", false);
        ShowRSVPs();        

        void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
        {
            if (inviteOnly)
            {
                // search guestList before adding rsvp
                bool found = false;
                foreach (string guest in guestList)
                {
                    if (guest.Equals(name))
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    System.Console.WriteLine($"\nSorry, {name} is not on the guest list");
                    return;
                }
            }

            rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
            count++;
        }
        void ShowRSVPs()
        {
            Console.WriteLine("\nTotal RSVPs:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(rsvps[i]);
            }
        }

    }
}
