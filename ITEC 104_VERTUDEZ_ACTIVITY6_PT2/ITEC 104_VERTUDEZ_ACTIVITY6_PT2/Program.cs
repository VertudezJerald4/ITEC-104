using System;
using System.Collections.Generic;
  
class GFG {
  
    
    public static void Main()
    {
  
        
        HashSet<string> mySet1 = new HashSet<string>();
  
        
        HashSet<string> mySet2 = new HashSet<string>();
  
        
        mySet1.Add("Hello");
        mySet1.Add("Geeks");
        mySet1.Add("GeeksforGeeks");
  
        
        mySet2.Add("Geeks");
        mySet2.Add("and");
        mySet2.Add("GeeksforGeeks");
        mySet2.Add("are");
        mySet2.Add("the");
        mySet2.Add("best");
  
        
        HashSet<string> ans = new HashSet<string>(mySet1);
  
        ans.IntersectWith(mySet2);
  
        
        foreach(string i in ans)
        {
            Console.WriteLine(i);
        }
    }
}