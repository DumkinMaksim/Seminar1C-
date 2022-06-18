//the program for finding an even number
int numbers, krats;
krats=2;
Console.Write("Enter number ");
numbers = Convert.ToInt32(Console.ReadLine()) ;
if (numbers % krats==0 ) //parity check
    {
        Console.WriteLine(numbers+"-> Yes");
    }   
    else
        {
             Console.WriteLine(numbers+"-> No"); 
        }
