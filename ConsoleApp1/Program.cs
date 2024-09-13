int poäng = 0;

Console.WriteLine("Fråga 1: Vad är huvudstaden i Sverige?");
Console.WriteLine("a) Stockholm");
Console.WriteLine("b) Göteborg");
Console.WriteLine("c) Malmö");
string svar1 = Console.ReadLine();

if (svar1 == "a")
{
    poäng++;
}

Console.WriteLine("Fråga 2: Vilket år landade den första människan på månen?");
Console.WriteLine("a) 1965");
Console.WriteLine("b) 1969");
Console.WriteLine("c) 1971");
string svar2 = Console.ReadLine();

if (svar2 == "b")
{
    poäng++;
}

Console.WriteLine("Fråga 3: Vilket är världens största hav?");
Console.WriteLine("a) Atlanten");
Console.WriteLine("b) Indiska oceanen");
Console.WriteLine("c) Stilla havet");
string svar3 = Console.ReadLine();

if (svar3 == "c")
{
    poäng++;
}

Console.WriteLine("Fråga 4: Vilken planet är närmast solen?");
Console.WriteLine("a) Venus");
Console.WriteLine("b) Merkurius");
Console.WriteLine("c) Mars");
string svar4 = Console.ReadLine();

if (svar4 == "b")
{
    poäng++;
}

Console.WriteLine("Fråga 5: Vad heter Sveriges kung?");
Console.WriteLine("a) Carl XVI Gustaf");
Console.WriteLine("b) Carl XII");
Console.WriteLine("c) Gustaf V");
string svar5 = Console.ReadLine();

if (svar5 == "a")
{
    poäng++;
}

Console.WriteLine("Fråga 6: Vad är den kemiska symbolen för vatten?");
Console.WriteLine("a) H2O");
Console.WriteLine("b) O2");
Console.WriteLine("c) CO2");
string svar6 = Console.ReadLine();

if (svar6 == "a")
{
    poäng++;
}

Console.WriteLine("Fråga 7: Vilket land ligger längst österut i Europa?");
Console.WriteLine("a) Portugal");
Console.WriteLine("b) Ryssland");
Console.WriteLine("c) Frankrike");
string svar7 = Console.ReadLine();

if (svar7 == "b")
{   
    poäng++;
}

Console.WriteLine("Fråga 8: Hur många världsdelar finns det?");
Console.WriteLine("a) 5");
Console.WriteLine("b) 6");
Console.WriteLine("c) 7");
string svar8 = Console.ReadLine();

if (svar8 == "c")
{
    poäng++;
}

Console.WriteLine("Fråga 9: Vilket grundämne har kemiska symbolen 'Au'?");
Console.WriteLine("a) Silver");
Console.WriteLine("b) Guld");
Console.WriteLine("c) Koppar");
string svar9 = Console.ReadLine();

if (svar9 == "b")
{
    poäng++;
}

Console.WriteLine("Fråga 10: Vilken färg har himlen på en klar dag?");
Console.WriteLine("a) Röd");
Console.WriteLine("b) Grön");
Console.WriteLine("c) Blå");
string svar10 = Console.ReadLine();

if (svar10 == "c")
{
    poäng++;
}

Console.WriteLine("Du fick " + poäng + " rätt av 10.");
Console.ReadLine();
