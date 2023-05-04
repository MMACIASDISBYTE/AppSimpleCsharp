// See https://aka.ms/new-console-template for more information
Console.WriteLine("Rock Paper Scissors");



while(true){
    Console.WriteLine("Are you ready?");
    Console.WriteLine("Let's begin!!!");

    var selectedChoice = SelectChoice();
    var yourChoice = char.Parse(selectedChoice);

    Console.WriteLine($"You Selected {yourChoice}");    

    var opponetChoice = GetOpponentChoice();
    Console.WriteLine($"I Choice {opponetChoice}");

    DecideWinner(opponetChoice, yourChoice);

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
};

void DecideWinner(char opponetChoice, char yourChoice){

    if(opponetChoice == yourChoice){
        Console.WriteLine("Tie!");
        return;
    }

    switch(yourChoice){
        case 'R':
        case 'r':
            if(opponetChoice == 'P')
                Console.WriteLine("Paper beats rock, I wind!");
            else if(opponetChoice == 'S')
                    Console.WriteLine("Rock beats Scissors, you win!");
            break;
        case 'S':
        case 's':
            if(opponetChoice == 'P')
                Console.WriteLine("Scissor beats Paper, you wind!");
            else if(opponetChoice == 'R')
                    Console.WriteLine("Rock beats Scissors, I win!");
            break;
        case 'P':
        case 'p':
            if(opponetChoice == 'S')
                Console.WriteLine("Scissors beats paper, I wind!");
            else if(opponetChoice == 'R')
                    Console.WriteLine("Paper beats Rock, you win!");
            break;
        default:
            break;
    };
}