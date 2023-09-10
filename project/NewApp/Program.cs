// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
internal class Program 
{
private static void Main(string[] args)
{


int a,b;
System.Console.Write("a=");
a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("b = ");
b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Hieu 2 so la {0} - {1}={2}",a,b,a-b);
System.Console.WriteLine("Tich 2 so la {0} * {1}={2}",a,b,a*b);
System.Console.WriteLine("Phan nguyen phep chia 2 so la {0} / {1}={2}",a,b,a/b);
System.Console.WriteLine("Phan du phep chia 2 so la {0} % {1}={2}",a,b,a%b);

}
}
