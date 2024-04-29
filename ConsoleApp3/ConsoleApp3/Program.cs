// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Ornek 1 
//var result1 = RemoveDuplicateCharacters("dijibil");
//Console.WriteLine(result1);

//static string RemoveDuplicateCharacters(string input)
//{
//    string data = "", result = "";

//    foreach (var value in input)
//    {
//        if (data.IndexOf(value) == -1)
//        {
//            data += value;
//            result += value;
//        }
//    }

//    return result;
//}

// Ornek 2


//Console.Write("İlk kelime:");
//string word1 = Console.ReadLine();

//Console.Write("İkinci kelime:");
//string word2 = Console.ReadLine();

//char[] c1 = word1.ToLower().ToCharArray();
//char[] c2 = word2.ToLower().ToCharArray();

//Array.Sort(c1);
//Array.Sort(c2);

//string str1 = new string(c1);
//string str2 = new string(c2);

//if (str1 == str2)
//{
//    Console.WriteLine("\"{0}\"ve \"{1}\" anagramdır,",str1, str2);
//}
//else
//{
//    Console.WriteLine("\"{0}\"ve \"{1}\" anagram değildir,", str1, str2);

//}

//Console.ReadLine();


// Ornek 3

//var result = WordCount("qwe feadsf er qw");
//Console.WriteLine(result);
//static int WordCount(string data)
//{
//    int result = 0;
//    data = data.Trim();

//    if (data == "")
//    {
//        return 0;
//    }

//    while (data.Contains("  "))
//    {
//        data = data.Replace("  ", " ");

//    }

//    foreach ( string d in data.Split(" "))
//    {
//        result++;
//    }

//    return result;  
//}

// Ornek 4

var result = Reverse("Cihan");
Console.WriteLine(result);
Console.ReadLine();
static string Reverse(string data)
{
    string result = "";

    for (global::System.Int32 i = data.Length - 1; i >= 0; i--)
    {
        result += data[i];
    }
    return result;  
}
