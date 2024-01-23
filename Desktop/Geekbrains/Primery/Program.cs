int[,] array =    {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            };
    
        int rows = array.GetUpperBound(0) + 1;
        int columns = array.Length;
         for (int i = 1; i < rows; i++)
         {
            for (int j = 1; j < columns; i++)
            {
                Console.WriteLine(array[i,j]);
            }
         }
        
       
    

