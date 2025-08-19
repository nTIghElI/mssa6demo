// namespace Day2;

// class Program2
// {
//     static void Main()
//     {
//         // double usd = 23.73;
//         // int vnd = UsdToVnd(usd);

//         // Console.WriteLine($"${usd} USD = ${vnd} VND");
//         // Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

//         // int UsdToVnd(double usd)
//         // {
//         //     int rate = 23500;
//         //     return (int)(rate * usd);
//         // }

//         // double VndToUsd(int vnd)
//         // {
//         //     int rate = 23500;
//         //     return vnd / rate;
//         // }
//         // string input = "snake";

//         // Console.WriteLine(input);
//         // Console.WriteLine(ReverseWord(input));

//         string input = "there are snakes at the zoo";
//         Console.WriteLine(input); 
//         Console.WriteLine(ReverseSentence(input));


//         string ReverseWord(string word)
//         {
//             string result = "";

//             for (int i = word.Length - 1; i >= 0; i--)
//             {
//                 result += word[i];
//             }
//             return result;
//         }

//         string ReverseSentence(string input)
//         {
//             string result = "";
//             string[] words = input.Split(" ");

//             foreach (string word in words)
//             {
//                 result += ReverseWord(word) + " ";
//             }
//             return result.Trim();
//         }



//     }




// }


