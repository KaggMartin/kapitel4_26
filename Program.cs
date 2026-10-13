using System.Security.Cryptography;

Random slumpare = new Random();     // Skapar en slumptalsgenerator. Görs bara EN gång.
Console.Clear();

int datortal = slumpare.Next(1, 101);     // Talet datorn tänker på, 1-100.
int gissning = 0;

while(gissning != datortal)               // Så länge vi gissar fel..
{
    // Gissa på ett tal..
    Console.WriteLine("Gissa på ett tal mellan 1-100.");
    gissning = int.Parse(Console.ReadLine());
    // Är det för högt
    if(gissning > datortal)
    {
        Console.WriteLine("Det var för högt!");
    }
    if(gissning < datortal)
    {
        Console.WriteLine("Det var för lågt!");
    }
}

Console.WriteLine("Rätt!!");



// Testar att slumpa tio "tärningskast".


for(int i=0; i<10; i++)                 // Räknar tio varv (0-9)
{
    int kast = slumpare.Next(1, 7);     // Ger ett slumptal mellan 1-6.
    Console.WriteLine($"Det blev en {kast}:a.");
}

// Kastar en tärning tills vi får en sexa.
int tarning = 0;
while(tarning != 6)
{
    tarning = slumpare.Next(1, 7);
    Console.WriteLine($"Du kastade en {tarning}:a.");
}

