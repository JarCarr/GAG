using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;


public class ArrayHandler : MonoBehaviour
{
    int[] TextToNumArray(string input) {
        int[] result;
        List<int> tempResult = new List<int>();

        string[] nums = input.Split(',');

        Array.Reverse(nums);

        foreach (string i in nums) {
            tempResult.Add(Convert.ToInt32(i));
        }

        result = tempResult.ToArray();

        return result;
    }



    string NumArrayToText(int[] array) {
        string result = "";

        Array.Reverse(array);

        foreach (int i in array) {
            result += Convert.ToString(i);
        }

        return result;
    }
}
