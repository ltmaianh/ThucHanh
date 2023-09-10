// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
internal class Program 
{
private static void Main(string[] args)
{


int a,b;
      System.Console.Write("a = ");
       a = Convert.ToInt32(Console.ReadLine());
      
      System.Console.Write("b = ");
       b = Convert.ToInt32(Console.ReadLine());
        if(a<b){
            Console.WriteLine("{0} nho hon {1}",a,b);
          } else if(a>b){
            Console.WriteLine("{0} lon hon {1}",a,b);
          }else{
            Console.WriteLine("{0} bang {1}",a,b);
          }

}
}
