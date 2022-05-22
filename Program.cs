// See https://aka.ms/new-console-template for more information

//create variables
string response;
int choice;
string name;
float cost;

Console.WriteLine("Hello, friendly traveler. What is your name? ");
name = Console.ReadLine();

Console.WriteLine("Please look through our offerings.");

//Generate the menu on the user's console
Console.WriteLine("-------------------------------------------------------" +
    "\nThe following supplies are available:" +
    "\n\n1 - Rope" +
    "\n2 - Torches" +
    "\n3 - Climbing Equipment" +
    "\n4 - Clean Water" +
    "\n5 - Machete" +
    "\n6 - Canoe" +
    "\n7 - Food Supplies" +
    "\n-------------------------------------------------------" +
    "\nWhat do you want off of the price list?");


//switch user input to correct output
choice = Convert.ToInt16(Console.ReadLine());
response = choice switch
{
    1 => "Rope",
    2 => "Torches",
    3 => "Climbing",
    4 => "Clean water",
    5 => "Machetes",
    6 => "Canoes",
    7 => "Food",
    _ => "something we don't sell."
};

cost = choice switch
{
    1 => 10,
    2 => 15,
    3 => 25,
    4 => 1,
    5 => 20,
    6 => 200,
    7 => 1,
    _ => 0
};

if (cost != 0)
{
    //Determine if discount is applied and provide output regardless of customer name.
    if (name == "Clinton" || name == "clinton")
    {
        Console.WriteLine(name + ", I see you are in the market for " + choice + ". Since you are such a good friend, I will only charge you " + cost / 2 + " gold.");
    }
    else
    {
        Console.WriteLine(name + ", I see you are in the market for " + choice + ". That will be " + cost + " gold.");
    }
}
else
{
    Console.WriteLine(name + ", I'm sorry we do not sell those here.");
}

//Hold from closing
Console.ReadKey();