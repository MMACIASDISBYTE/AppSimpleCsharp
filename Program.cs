// See https://aka.ms/new-console-template for more information
Console.WriteLine("Rock Paper Scissors");



while(true){
    Console.WriteLine("Are you ready?");
    Console.WriteLine("Let's begin!!!");

    var selectedChoice = SelectChoice();
    var yourChoice = char.Parse(selectedChoice);

    Console.WriteLine($"You Selected {yourChoice}");    

    var opponetChoice = GetOpponentChoice();
    Console.WriteLine("----------");
    Console.WriteLine($"I Choice {opponetChoice}");
    Console.WriteLine("----------");
}; 

string SelectChoice()
{
    Console.WriteLine("Choose R, P or S []: [R]ock, [P]aper, or [S]cissors: ");
    var selectedChoice = Console.ReadLine(); //espera a q el usuario escriba un comando

    // if(selectedChoise?.ToLower() != 'r' or )
    if(selectedChoice?.ToLower() != "r" && selectedChoice?.ToLower() != "p" && selectedChoice?.ToLower() != "s")
    {
        Console.WriteLine("Please, select only one letter: R, P o S");
        selectedChoice = SelectChoice();
    }
    return selectedChoice;
};

char GetOpponentChoice()
{
    char[] options = new char[] { 'R', 'P', 'S'};

    Random random = new Random();

    int randomIndex = random.Next(0, options.Length);

    return options[randomIndex];
}