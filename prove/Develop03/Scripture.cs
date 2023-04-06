using System;
using ReferenceSystem;
using WordSystem;

namespace ScriptureSystem;
public class Scripture 
{
    private Reference reference = new Reference();   // new instance of Reference class
    private Word word;                              
    private string[] completeVerse = null;              
    public string[] passage;
    public int randomNumber = 0;
    public int hiddenWords = 0;


    public Scripture(Word word1)                     // Using the existing word instance already created in main functuion
    {
        word = word1;
        passage = ProcessPassage();
    }

    public int GetRandomWord()                        // generates random word as a random index from passage length
    {
        Random random = new Random();
        randomNumber = random.Next(passage.Length);
        return randomNumber;
    }
    private string[] ProcessPassage()                //  combines multi-verse passages, splits them into an array of words and returns the complete verse
    {
        string fullPassage = "";
        if (reference._Reference2 != null)
        {
            fullPassage = (reference._Reference + "; " + reference._Reference2);
        }
        else
        {
            fullPassage = reference._Reference;      
        }
        completeVerse = fullPassage.Split(" ");
        return completeVerse;
    }
    
    public void HideWords()                           // hides 3 words at a time
    {
        int numToHide = 3;    
        if (passage.Length == hiddenWords)
        {
            return;
        }
        else if (passage.Length - 3 <= hiddenWords)
        {
            numToHide = completeVerse.Length - hiddenWords;
        }
            
        for (int i = 0; i < numToHide; i++)           // iterates through i until it reaches set numToHide number, then hides the current indexed word
        {
            randomNumber = GetRandomWord();
            word.hidden = word.WordHidden(randomNumber);
            if (word.hidden == false)
            {
                word.WriteHiddenWord(randomNumber);
                hiddenWords +=1;
            }
            else
            {
                i = i - 1;
            }
        }
    }
    
    
}