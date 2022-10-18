// See https://aka.ms/new-console-template for more information
// John Magpantay
// 10-18-22
// Revamped mini challenges 
// Peer review {}
Console.WriteLine("Hello, World!");

string playAgain = "yes";
while( playAgain == "yes"){
    Console.WriteLine("Hi, What is your name?");
    Console.WriteLine("");

    String myName = Console.ReadLine();
    String phrase = "Please Enter the second number!";

    Console.WriteLine("Hello, " + myName);

    Console.WriteLine("Welcome to my Revamp challenges!");
    Console.WriteLine("Let's add two numbers, give me your first number");

    string num1 = Console.ReadLine();

    Console.WriteLine(phrase);
    string num2 = Console.ReadLine();

    int x = Convert.ToInt32(num1);
    int y = Convert.ToInt32(num2);

    int sum = x + y;



    //string name = $"The numbers combined is : (num1 + num2)";

    Console.WriteLine("total number is : ");
    Console.WriteLine(sum);


    //int x = Console.ReadLine

    Console.WriteLine ("Would you like to do it again? yes or no?");

playAgain = Console.ReadLine();

}


