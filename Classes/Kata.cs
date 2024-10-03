 
 
 
 public static class Kata {
 
 public static long QueueTime(int[] customers, int n)
    {
        int timeSpent = 0;
        int customerIndex = 0;
        int timeInterval = 0;
        int replacementIndex = 0;

        
        try
        {
             List<(int, int)> tills = new List<(int, int)>();

        for (int i = 0; i < n && i < customers.Length; i++)
        {
            tills.Add( new (i, customers[i]));
            customerIndex += 1;
        }

        timeInterval = tills.Min(t => t.Item2);
    
        Console.WriteLine(tills.Max(t => t.Item2));
        int condition = tills.Max(t => t.Item2);
        while(condition > 0) {
            timeSpent += timeInterval;
            for (int i = 0; i < n && i < customers.Length; i++)
            {
                
                tills[i] = new (i, tills[i].Item2 - timeInterval);
                
            }
            for (int i = 0; i < n; i++)
            {
                if (tills.Any(m => m.Item2 == 0) && customerIndex < customers.Length) {
                replacementIndex = tills.FindIndex(i => i.Item2 == 0);
                tills[replacementIndex] = new (replacementIndex, customers[customerIndex]);
                Console.WriteLine($"Number of loops {i}");
                customerIndex += 1;
            }
            }
            
             
            if (tills.Min(t => t.Item2) > 0) {
                timeInterval = tills.Min(t => t.Item2);
                Console.WriteLine($"Runs min");
            } else {
                timeInterval = tills.Max(t => t.Item2);
                Console.WriteLine("Runs max");
            }
            
            
            condition = tills.Max(t => t.Item2);

       
    }
     return timeSpent;
        }
        catch (System.Exception)
        {
            return 0;
            throw;
        }
       
    }
}
