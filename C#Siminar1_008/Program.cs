int  a, index;
Console.Write("Input N= ") ;
a = Convert.ToInt32(Console.ReadLine()) ;
 for (index = 1; index<a+1; index++)
    {
        if (index==1)
        {
            Console.WriteLine("even numbers not found "); 
        }
        if (index % 2==0)
        {
             Console.Write(index+"  "); 
        }
    }