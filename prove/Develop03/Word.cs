using System;
using ScriptureSystem;

namespace WordSystem;
public class Word
{    
    public bool hidden = false;
    public string[] splitPassage;
    
    public bool WordHidden(int word)                              // determines if a word is hidden based on "____"
    {
        if (splitPassage[word] == "____")
        {
            hidden = true;
        }
        else
        {
            hidden = false;
        }
        return hidden;
    }
    
    public void DisplayWords()                                  // displays the updated string with hidden words in it
    {
        foreach(var item in splitPassage)
            {
                Console.Write(item.ToString() + " ");
            }
    }
  public void WriteHiddenWord(int randomNumber)               // hides words based on random number and if they arn't a symbol
    {
        foreach (char letter in splitPassage[randomNumber])
        {
            splitPassage[randomNumber] = "____";
        }
    }
}

