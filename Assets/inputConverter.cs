using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text.RegularExpressions;

public class inputConverter : MonoBehaviour
{
    public string ConvertInputDist(string userInput)
    {
        string inputString = userInput;

        string pattern = @"\d+";

        Match match = Regex.Match(inputString, pattern);

        if (match.Success)
        {
            string matchedNumber = match.Value;

            //int number = int.Parse(matchedNumber);

            //return number;
            return matchedNumber;
        }
        else
        {
            return "Error";
        }
    }

    public string ConvertInputDir(string userInput)
    {
        int correct = 0;
        string correctword = "right";
        string myString = userInput.ToLowerInvariant();
        char delimiter = ' ';
        string[] possibleWords = { "right", "left", "up", "down" };

    string[] words = myString.Split(delimiter);
        foreach (string word in words)
        {
            if (Array.IndexOf(possibleWords, word) >= 0)
            {
                correctword = word;
                correct = 1;
                break;
            }
            
        }
        if ( correct == 0)
        {
            return "Error";
        }
        else
        {
            return correctword;
        }
        


    }
}
