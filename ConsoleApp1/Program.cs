Console.WriteLine("Användarnamn:");
string name = Console.ReadLine();

Console.WriteLine(name + " går in i skogen och hittar en rostig cykel, väljer du att inte åka på den?");
Console.WriteLine("Ja");
Console.WriteLine("Nej");

string val1 = Console.ReadLine();

if (val1 == "Nej" || val1 == "nej")

{
    Console.Clear();
    Console.WriteLine(name + " går tillbaka på stigen och hittar en fylld spruta på marken, väljer du att använda den på dig själv?");
    Console.WriteLine("Ja");
    Console.WriteLine("Nej");

    string val2 = Console.ReadLine();

    if (val2 == "Ja" || val2 == "ja");

    {
        Console.Clear();
        Console.WriteLine("Sprutan var fylld av fentanyl och " + name + " upplever en fantastisk eufori innan " + name + " till slut dör av en överdosning");
        Console.WriteLine("Du förlorade");
    }

     
 if (val2 == "Nej" || val2 == "nej") 
    {
        Console.Clear();
     Console.WriteLine("Medans " + name + " var upptagen med att tänka igenom med vad han skulle göra med sprutan så dog han av en björn i skogen");
     Console.WriteLine("Du förlorade");
    }
}

if (val1 == "Ja" || val1 == "ja") {
    Console.Clear();
    Console.WriteLine("Efter 15 minuter av ansträngande trampning hittar " + name + " en övergiven stuga, väljer du att gå in i stugan?");
    Console.WriteLine("Ja");
    Console.WriteLine("Nej");

    string val3 = Console.ReadLine();

    if (val3 == "Ja" || val3 == "ja") 
    {
        Console.Clear();
        Console.WriteLine(name + " kliver in i stugan och märker att en av golvplankorna sitter löst, väljer du att kolla under plankan?");
        Console.WriteLine("Ja");
        Console.WriteLine("Nej");

        string val4 = Console.ReadLine();
        if (val4 == "Ja" || val4 == "ja")
        {
            Console.Clear();
            Console.WriteLine(name + " hittar en låda fylld av smycken och dyra ägodelar, du vann");
        }

        if (val4 == "Nej" || val4 == "nej") 
        {
            Console.Clear();
            Console.WriteLine(name + " går ut ur stugan och råkar trampa på en rostig spik gömd i dom fallna löven, " + name + " dör av stelkramp 2 dagar efter");
        }
    }

    if (val3 == "Nej" || val3 == "nej") 
    {
        Console.WriteLine("Gratulerar " + name + " du fick det tråkigaste slutet, du går hem efter att du bestämde dig för att inte gå in i stugan");
    }

}

Console.ReadLine();