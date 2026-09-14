//THis is the Sncak Split program, and it hopefully works

Console.WriteLine("Welcome to Snacks Split");

Console.Write("How many gummy bears? ");
int gummyBears = Convert.ToInt32(Console.ReadLine());

Console.Write("How many Chips? ");
int chips = Convert.ToInt32(Console.ReadLine());

Console.Write("How many people? ");
int people = Convert.ToInt32(Console.ReadLine());

int snackCount = gummyBears + chips;

int each = snackCount/people;
int leftover = snackCount - (snackCount/people) * people;

Console.WriteLine("Everyone gets " + each);

Console.WriteLine("Left in the bag: " + leftover);

// Requirement if everyone gets fewer than 3 snacks than 3 snacks tell them to buy more

if (each < 3)
{
    Console.WriteLine("Buy more snacks!");
}
else
{
   Console.WriteLine("Enjoy your snacks!");; 
}
