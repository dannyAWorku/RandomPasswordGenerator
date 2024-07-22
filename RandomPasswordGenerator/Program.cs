// See https://aka.ms/new-console-template for more information
using RandomPasswordGenerator;

Console.WriteLine("The Number of Passwords needed");

int numberOfPasswords = Convert.ToInt32(Console.ReadLine());
Generator generator =new Generator(numberOfPasswords);
string[]  passwords = generator.GetPasswords();

for (int i = 0; i < passwords.Length; i++)
{
    Console.WriteLine(passwords[i]);
}
