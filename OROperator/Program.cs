

int math, chemistry;

Console.WriteLine("Enter your Math result");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry result");
chemistry = Int32.Parse(Console.ReadLine());

if (math >= 90 || chemistry >= 90)
{
    Console.WriteLine("Congratz! You have been accepted!");
}
else
{
    Console.WriteLine("Your application cannot be approven");
}