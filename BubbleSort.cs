using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BubbleSort : MonoBehaviour
{
    public List<int> BubbleSortAlgorithm(List<int> numbers)
    {
        int n = numbers.Count;
        List<int> sortedList = new List<int>(numbers); 

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                
                if (sortedList[j] > sortedList[j + 1])
                {
                    
                    int temp = sortedList[j];
                    sortedList[j] = sortedList[j + 1];
                    sortedList[j + 1] = temp;
                }
            }
        }

        return sortedList;
    }

    void Start()
    {
        List<int> unsortedList = new List<int> { 64, 34, 25, 12, 22, 11, 90 };

        Debug.Log("Unsorted List: " + string.Join(", ", unsortedList));

        List<int> sortedList = BubbleSortAlgorithm(unsortedList);

        Debug.Log("Sorted List: " + string.Join(", ", sortedList));
    }
}
