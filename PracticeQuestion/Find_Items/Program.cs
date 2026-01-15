using System;
using System.Collections.Generic;
using System.Linq;

class Program 
{
    public static SortedDictionary<string, long> itemDetails = new SortedDictionary<string, long>()
    {
        {"Pen", 52},
        {"Pencil", 120},
        {"Notebook", 100},
        {"Book", 807},
        {"Bag", 99}
    };

    public static SortedDictionary<string, long> FindItemDetails(long soldCount){
        SortedDictionary<string, long> result = new SortedDictionary<string, long>();

        foreach (var item in itemDetails){
            if (item.Value == soldCount){
                result.Add(item.Key, item.Value);
            }
        }

        return result;
    }

    public static List<string> FindMinandMaxSoldItems(){
        List<string> output = new List<string>();

        long minSold = itemDetails.Values.Min();
        long maxSold = itemDetails.Values.Max();

        string minItemName = "";
        string maxItemName = "";

        foreach (var item in itemDetails){
            if (item.Value == minSold)
                minItemName = item.Key;

            if (item.Value == maxSold)
                maxItemName = item.Key;
        }

        output.Add(minItemName); 
        output.Add(maxItemName);

        return output;
    }

    public static Dictionary<string, long> SortByCount(){
        Dictionary<string, long> sortedResult = itemDetails
            .OrderBy(x => x.Value)
            .ToDictionary(x => x.Key, x => x.Value);

        return sortedResult;
    }

    static void Main(string[] args){
        Console.WriteLine("Enter sold count:");
        long soldCount = long.Parse(Console.ReadLine());

        SortedDictionary<string, long> found = FindItemDetails(soldCount);

        if (found.Count == 0){
            Console.WriteLine("Invalid");
        }
        else{
            Console.WriteLine("Item Details:");
            foreach (var item in found){
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }

        List<string> minMaxItems = FindMinandMaxSoldItems();
        Console.WriteLine("Minimum: " + minMaxItems[0]);
        Console.WriteLine("Maximum: " + minMaxItems[1]);

        Console.WriteLine("Sorted Item Details:");
        Dictionary<string, long> sorted = SortByCount();
        foreach (var item in sorted){
            Console.WriteLine(item.Key + " " + item.Value);
        }                    
    }
}
