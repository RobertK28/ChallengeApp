
using System.Diagnostics.CodeAnalysis;

int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToCharArray();
List<char> charsNr = numberInString.ToCharArray().ToList();


//int numberRange = 1234567890;
//string numberRangeInString = numberRange.ToString();
string numberRangeInString = "0123456789";
char[] lettersRange = numberRangeInString.ToCharArray();
List<char> charsRange = new List<char>();
charsRange = numberRangeInString.ToCharArray().ToList();

//Listy
foreach (char chRange in charsRange)
{
    int i = 0; 
    foreach (char chNr in charsNr)
    {
        if (chRange == chNr)
            i++;
    }
    Console.WriteLine(chRange + " => " + i);
}

// Tablice
foreach (var nrRange in lettersRange)
{ 
    int i = 0;
    foreach (var nr in letters)
    {
        if (nrRange == nr)
            i++;
    }   
    //Console.WriteLine(nrRange + " => " + i);
}
