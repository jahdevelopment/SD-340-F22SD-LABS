using System.Text;

//Write a delegate that returns a string from a method with a signature of (string wordArg, int numArg).
//Use it to invoke one method that returns a word concatenated x number of times, and then a method that removes x many letters from the end of the word.

StringDelegate delegateOne = new StringDelegate(WordsToConcat);

StringDelegate delegateTwo = new StringDelegate(cutWord);

Console.WriteLine(delegateOne("Awesome", 5));
Console.WriteLine("\n");
Console.WriteLine(delegateTwo("Winnipeg", 3));
Console.WriteLine("\n");
delegateOne = cutWord;
Console.WriteLine(delegateOne("Manitoba",3));

string WordsToConcat(string word, int counter)
{
    StringBuilder sb = new StringBuilder();

    for(int i = 0; i < counter; i++)
    {
        sb.Append(word);
    }
    return sb.ToString();
}


string cutWord(string word, int charsToCut)
{
    if(word.Length >= charsToCut)
    {
        return word.Substring(0, word.Length - charsToCut);
    }
    else 
    {
        return word; 
    }
}


delegate string StringDelegate(string wordArg, int numArg);

