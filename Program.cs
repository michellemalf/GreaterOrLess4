//Michelle Malfabon
//Aug 10 2022
//Description: Declared the variables for number 1 and number 2. Used if statements to compare the numbers and print a matching phrase accordingly. 


//----------MINI 4 ----- GREATER OR LESS THAN-----------////

//You will ask the user to enter in two numbers.  You will then print the following 2 statements.
int num1;
int num2;
int playAgain;

void PlayGame()
{
Console.WriteLine("Enter a number: ");
num1= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a second number: ");
num2= Convert.ToInt32(Console.ReadLine());
//The first statement should tell me if the first number is greater than, less than or equal to the second number. 
if(num1==num2)
{
    Console.WriteLine(num1+ " is equal to " + num2);
}
if(num1 >num2)
{
    Console.WriteLine(num1+ " is greater than " + num2);
}
if(num1 < num2)
{
    Console.WriteLine(num1+ " is less than " + num2);
}
//The second statement should tell me if the second number is greater than, less than, or equal to the first number.
if(num2 == num1)
{
    Console.WriteLine(num2+ " is equal to " + num1);
}
if(num2 >num1)
{
    Console.WriteLine(num2+ " is greater than " + num1);
}
if(num2 < num1)
{
    Console.WriteLine(num2+ " is less than " + num1);
}
Console.WriteLine("Enter 0 to play again.");
playAgain= Convert.ToInt32(Console.ReadLine());
if (playAgain == 0)
{
    PlayGame();
}
else{
    Console.WriteLine("Goodbye.");
}
}
PlayGame();

