using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    
    public static int truckTour(List<List<int>> petrolpumps) {
        int n = petrolpumps.Count;
        int start = 0;
        int totalPetrol = 0;
        int currentPetrol = 0;
        
        for (int i = 0; i < n; i++) {
            int petrol = petrolpumps[i][0];
            int distance = petrolpumps[i][1];
            
            totalPetrol += petrol - distance;
            currentPetrol += petrol - distance;
            
            // If we can't reach the next station from current start
            if (currentPetrol < 0) {
                start = i + 1;
                currentPetrol = 0;
            }
        }
        
        // If total petrol is negative, no solution exists
        return totalPetrol >= 0 ? start : -1;
    }

    public static void Main(string[] args) {
        // Test case
        var petrolpumps = new List<List<int>> {
            new List<int> {1, 5},
            new List<int> {10, 3},
            new List<int> {3, 4}
        };
        
        Console.WriteLine(truckTour(petrolpumps)); // Output: 1
    }
}
