using System.Security.Cryptography;

Random slumpare = new Random();     // Skapar en slumptalsgenerator. Görs bara EN gång.
Console.Clear();

int pengar = 1000;
while(pengar > 0)
{
    Console.WriteLine($"Du har {pengar}kr.");
    Console.WriteLine("Satsa på ett tal mellan 0-9");
    int satsning = int.Parse(Console.ReadLine());

    // variabel med pengar
    // variabel med en gissning/satsning
    // Skriv ut "Satsa på ett tal 0-9
    // Ta emot gissningen..
    int hjul = slumpare.Next(20, 50); // hjul är hur länge hjulet snurrar.
    int bingo = 9;                    // bingo är det tal som visas just nu.
    int wait = 750/hjul;              // En uträkning för hur snabbt det går.
    for(int i=0; i<hjul; i++)       // Vi kör ett slumpmässigt antal varv.
    {
        bingo++;
        if(bingo == 10)             // Om bingo är tio så...
            bingo = 0;              // ..börjar vi om på noll.
        Console.Clear();            // Rensar consolfönstret.
        for(int m=0; m<bingo; m++)  // Loopar från 0-bingo
            Console.Write(" ");     // Skriver ut ett mellanslag
        Console.WriteLine(bingo);   // Skriver ut talet (efter alla mellanslag)
        Thread.Sleep(15+i*wait);    // Väntar först 15ms sedan längre för varje varv.
    }
    // Kolla om gissningen var rätt (bingo)
    // Öka pengarna eller minska om det var fel.
    
    
    
    
    
    
    Thread.Sleep(1000);
    if(satsning == bingo)
    {
        Console.WriteLine("$$$ Du VANN!! $$$");
        pengar += 300;
    }
    else
    {
        Console.WriteLine("Du förlorade!");
        pengar -= 100;
    }
}






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

