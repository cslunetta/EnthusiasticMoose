using System;

Main();

void Main()
{
Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();

// Let the moose speak!
MooseSays("H I, I'M  E N T H U S I A S T I C !");
MooseSays("I really am enthusiastic");

// Ask some questions
CanadaQuestion();
EnthusiasticQuestion();
LoveCSharpQuestion();
SecretQuestion();
}

// question to ask / answer if y / answer if n
void CanadaQuestion()
{
    Question("Is Canada real?", "Really? It seems very unlikely.", "I  K N E W  I T!!!");
}

void EnthusiasticQuestion()
{
    Question("Are you enthusiastic?", "Yay!", "You should try it!");
}

void LoveCSharpQuestion()
{
    Question("Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will...");
}

void SecretQuestion()
{
    Question("Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");
}

// based on the question asked... if true sayTrue / else sayFalse
void Question(string ask, string sayTrue, string sayFalse)
{
    bool isTrue = MooseAsks($"{ask}");
    if (isTrue)
    {
        MooseSays($"{sayTrue}");
    }
    else
    {
        MooseSays($"{sayFalse}");
    }
};

bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}

void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}
