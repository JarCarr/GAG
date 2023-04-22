using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;


public class ArrayHandler : MonoBehaviour
{
    public static bool[] TextToNumArray(string input) {
        bool[] result;
        List<bool> tempResult = new List<bool>();

        string[] nums = input.Split(',');

        Array.Reverse(nums);
        int tempnum = 0;
        foreach (string i in nums) {
            tempnum = Convert.ToInt32(i);
            tempResult.Add(Convert.ToBoolean(tempnum));
        }

        result = tempResult.ToArray();

        return result;
    }



    public static string NumArrayToText(bool[] array) {
        string result = "";

        Array.Reverse(array);
        int tempnum = 0;
        foreach (bool i in array) {
            tempnum = Convert.ToInt32(i);
            result += Convert.ToString(tempnum);
        }

        return result;
    }


    public static bool IsValidButton() {

        bool[] values = TextToNumArray(PlayerPrefs.GetString("score"));

        /* PLAN 1:


            give the poster buttons a script that gives them 2 attributes: audio and interact

            I = 0
            in start, loop through children of "canvas"
            if I=1
                button = interractable
            else
                button = uninterractable


            when button is pressed
            if button.GetComponent<script>().variable = true
                make sound





        */
        
        // PLAN 2:
        /*
            
            on menu start, put the values into array

            give each button an "ID" via a script
            if value[id] = true, play audio


        */


        //
        return true;
    }
}
