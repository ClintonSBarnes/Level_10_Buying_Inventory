// See https://aka.ms/new-console-template for more information

//create variables
string response;
int choice;

//Generate the menu on the user's console
Console.WriteLine("-------------------------------------------------------" +
    "\nThe following supplies are available:"+
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
choice = Convert.ToInt16( Console.ReadLine());
response = choice switch
{
    1 => "Rope costs 10 gold.",
    2 => "Torches cost 15 gold.",
    3 => "Climbing equipment costs 25 gold.",
    4 => "Clean water costs 1 gold.",
    5 => "Machetes cost 20 gold.",
    6 => "Canoes cost 200 gold.",
    7 => "Food supplies cost 1 gold.",
    _ => "Sorry, we don't carry any of those."
};

//output statement
Console.WriteLine(response);
Console.ReadKey();