/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.WriteLine("enter a five-digit number: ");
string number = Console.ReadLine();
if (number.Length == 5 && number[0]==number[4] && number[1]==number[3])
{
    Console.WriteLine("the number is a palindrome");
}
else
{
    Console.WriteLine("number is not a palindrome");
}