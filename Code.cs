using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Code : MonoBehaviour
{

    public int SumEvenNumbers(List<int> numbers)
    {
        int sum = 0;

        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                sum += number;
            }
        }

        return sum;
    }

    void Start()
    {
        
        List<int> testNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        
        int result = SumEvenNumbers(testNumbers);

        Debug.LogWarning("Sum of even numbers: " + result);  
                                                             
    }
}
