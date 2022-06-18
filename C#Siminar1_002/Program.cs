// min and max search program from two numbers
int  a, b;
Console.Write("Input a= ") ;
a = Convert.ToInt32(Console.ReadLine()) ;
Console.Write("Input b= ") ;
b = Convert.ToInt32(Console.ReadLine()) ;
if (a>b)
 {
    Console.WriteLine("Max= "+a) ;
    Console.WriteLine("Min= "+b) ;
}
else 
{
    if (a==b) 
    {
    Console.WriteLine("no min or max, the numbers are equal");
    Console.WriteLine(a+"="+b);
  }
  else
    {
    Console.WriteLine("Max= "+b) ;
    Console.WriteLine("Min= "+a) ;
    }
}