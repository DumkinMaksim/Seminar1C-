
        // search program max numbers out of three
       int [] a= new int [3];
        int i ;
        int max = a[0];
        Console.Write("Enter first number ");
        a[0] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second numbers ");
        a[1] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the third number ");
        a[2] = Convert.ToInt32(Console.ReadLine());
         for (i = 0; i<3; i++)
          {
         {
            if (a[i] > a[i++])
            {
              max=a[i];  
            } 
               else 
               { 
                max = a[i++];    
        }
        Console.WriteLine("Max="+max);
         }
          }
          