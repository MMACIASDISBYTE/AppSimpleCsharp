Console.WriteLine("Guess the Number!");

startGame();

void startGame(){
    Console.WriteLine("Hello, welcome to the game...");
    Console.WriteLine("Whats's your name?");
    var player = Console.ReadLine();
    Console.WriteLine($"Hi {player}, are you ready to play? (Enter Yes/No)");

    var wantToPlay = Console.ReadLine();

    switch(wantToPlay?.ToLower()){ //el ? valida su no nulalidad
        case "yes":
            break;
        case "no":
            break;
        default:
            Console.WriteLine("That is not a valid option, please enter Yes or No");
        break;
    }
};

void Play(){

};

void DontPlay(){

};