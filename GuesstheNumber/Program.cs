string? player;
Random random = new Random();
int attemps = 0;
int highestScoreAttempts = 0;

Console.WriteLine("Guess the Number!");

startGame();

void startGame(){
    Console.WriteLine("Hello, welcome to the game...");
    Console.WriteLine("Whats's your name?");

    int randomNum = random.Next(1, 10);

    player = Console.ReadLine();
    WantToPlay(randomNum);
};

void WantToPlay(int randomNum, bool playAgain = false){

    if(!playAgain)
        Console.WriteLine($"Hi {player}, are you ready to play? (Enter Yes/No)");
    else
        Console.WriteLine($"{player}, are you ready to play again? (Enter Yes/No)");

    var wantToPlay = Console.ReadLine();

    switch(wantToPlay?.ToLower().Trim()){ //el ? valida su no nulalidad, primero tranformamos a minusculas y luego borramos los espacios hacia ambos costados
        case "yes":
            Play(randomNum);
            break;
        case "no":
            DontPlay();
            break;
        default:
            Console.WriteLine("That is not a valid option.");
            WantToPlay(randomNum); //aqui se aplica recursividad
        break;
    }
}

void Play(int randomNum){

    try
    {
        Console.WriteLine("Pick a number between 1 and 10");
        var pickedNumber = Console.ReadLine();

        if(pickedNumber is null)
            throw new Exception("you need to pick a value"); //de esta manera manejamos los errores
        
        if( int.Parse(pickedNumber) < 1 || int.Parse(pickedNumber) > 10)
            throw new Exception("Please pick a numbew between 1 and 10");

        if(int.Parse(pickedNumber) == randomNum){
            YouGuess();
        }
        else if(int.Parse(pickedNumber) < randomNum){
            Console.WriteLine("Try again the number is higher...");
            attemps++;
            Play(randomNum);
        }else if(int.Parse(pickedNumber) > randomNum){
            Console.WriteLine("try again the number is lower...");
            attemps++;
            Play(randomNum);
        }
    }
    catch (Exception e)
    {
        Console.WriteLine($"there has been an error {e.Message}");
        Play(randomNum); //requerimos la recursividad
    }
};

void DontPlay(){
    Console.WriteLine("No worries!have a good one!");
};

void YouGuess(){
    Console.WriteLine("Nice you guessed the number!");
    highestScoreAttempts++;

    if(highestScoreAttempts == 0 || attemps < highestScoreAttempts)
        highestScoreAttempts = attemps;
    ShowScore();
    int randomNum = random.Next(1, 10);
    Console.WriteLine($"It has taken {attemps} attemps");
    attemps = 0;
    WantToPlay(randomNum, true);
};

void ShowScore(){
    if(highestScoreAttempts == 0){
        Console.WriteLine("There is currently no hight score, it's your for the taking!");
    }else{
        Console.WriteLine($"The current hight score is {highestScoreAttempts} attempts!");
    };
};