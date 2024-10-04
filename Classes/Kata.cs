


using System.Data;
using System.Numerics;
using System.Xml.XPath;

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

    public static string sumStrings(string a, string b)
    {
        BigInteger value1;
        BigInteger value2;

        if (a != "") {
            value1 = BigInteger.Parse(a);
        } else {
            value1 = 0;
        }
        if (b != "") {
            value2 = BigInteger.Parse(b);
        } else {
            value2 = 0;
        }

       
        BigInteger sum = value1 + value2;
        return sum.ToString();
    }
    public static List<object> JosephusPermutation(List<object> items, int k)
   {
        List<object> resultingList = new List<object>();
        
        int counter = 0;
        int removeObjectIndex = -1;
        int startIndex = 0;

        while (items.Count() > 0) {
            
            for (int i = startIndex; i < k + startIndex; i++)
            {
                if (removeObjectIndex < items.Count() - 1) {
                    removeObjectIndex += 1;
                } else {
                    removeObjectIndex = 0;
                }
                
            }
            resultingList.Add(items[removeObjectIndex]);
            items.RemoveAt(removeObjectIndex);
            counter += 1;
            removeObjectIndex -= 1;
            
        }
        foreach (var item in resultingList)
        {
            Console.WriteLine(item);
        }
       return resultingList;
   }
}


