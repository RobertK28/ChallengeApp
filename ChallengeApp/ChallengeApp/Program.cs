

var name = "Ewa";
var age = 28;
bool plecKobieta = true;
//plecKobieta = false;


if (plecKobieta && age < 30)
{
    Console.WriteLine("Kobieta poinżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (!(plecKobieta) && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}

if (plecKobieta)
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta poinżej 30 lat");
    }
    else if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }
}
else if (!plecKobieta)
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni Mężczyzna");
    }
