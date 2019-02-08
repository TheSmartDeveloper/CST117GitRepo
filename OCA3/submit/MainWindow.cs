/*
 * Name: Kevin George
 * Teac: Prof. Gordon
 * Clas: CST-135 900A
 * Date: Oct 10, 2018
 */

using System;
using System.IO;        //what's needed for input, output, file reading, & writing
using System.Threading;     //not needed. I was trying something else.
using System.Collections.Generic;       //needed for the hash set in the most vowels method
using Gtk;

public partial class MainWindow : Gtk.Window
{
    
	public MainWindow() : base(Gtk.WindowType.Toplevel)             //method to build the main window
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)      //method for when the user presses the 'x' button at the top of the window
    {
        Application.Quit();
        a.RetVal = true;
    }
    void lowerCase(string[] lc)         //method for setting each word to lowercase
	{
		string eachWord = " ";          //temporary string for storing each word to be lowercased
		for (int i = 0; i < lc.Length; i++)     //for loop that goes from 0 to the length of the string by one each time
		{
			eachWord = lc[i];           //whatever is in lc[i] is passed into eachWord
			eachWord = eachWord.ToLower();      //eachWord is lowercased
			lc[i] = eachWord;           //lc[i] is overwritten with the new lowercased word
			System.IO.File.WriteAllLines(@"/home/kevin/Kevin/school/CST117/workspace/OCA3/lowerCase.txt", lc);      // lc array printed out to the text file
		}      
	}
	void alphabetically(string[] ab)        //method for sorting each word alphabetically
	{
		Array.Sort(ab);         //sort array using the in-built C# sorting method
		System.IO.File.WriteAllLines(@"/home/kevin/Kevin/school/CST117/workspace/OCA3/alphabetically.txt", ab);     //ab array printed out to the text file
	}
	void longestWord(string[] lw)        //method for finding the longest word
	{
		string longWord = " ";          //string created where the longest word would be stored
		string[] tooLong = new string[1];       //new string array created that will only be 1 element long because that is all we need
		for (int i = 0; i < lw.Length; i++)     //for loop that goes from 0 to the length of the string by one each time     
		{
			if(lw[i].Length > longWord.Length)      //check if the value in the array it indice 'i' is longer than the string 'longWord'
			{
				longWord = lw[i];           //if so, set 'longWord' to indice 'i'
			}         
		}
		tooLong[0] = longWord;          //put whatever was in 'longWord' into the array 'tooLong' and that will be the longest word
		System.IO.File.WriteAllLines(@"/home/kevin/Kevin/school/CST117/workspace/OCA3/longestWordinFile.txt", tooLong);     //tooLong array printed out to the text file
	}
	void moistVowels(string[] mv)        //method for finding the word with the most vowels
	{
		string theWord = " ";          //string created where the word would be stored
		int vowCount = 0;          //int created to hold how many vowels the word would hold
		string[] wordwMostVow = new string[1];             //new string array created that will only be 1 element long because that is all we need
		var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };        //char set that includes all variants of the vowel so that when we scan through the string we can check for these
		for (int i = 0; i < mv.Length; i++)     //for loop that goes from 0 to the length of the string by one each time
		{
			if(mv[i].Length > theWord.Length)      //check if the value in the array it indice 'i' is longer than the string 'theWord'
            {
				theWord = mv[i];           //if so, set 'theWord' to indice 'i'            
            }         
		}
		for (int j = 0; j < theWord.Length; j++)     //for loop that goes from 0 to the length of the string by one each time
        {
            if (vowels.Contains(theWord[j]))        //if the string at indice j contains a character in vowel increase the vowel count by one
            {
                vowCount++;
            }
        }
		wordwMostVow[0] = "The word with the most vowels is: " +"'"+ theWord +"'"+ " with " + vowCount.ToString() + " vowels";      //formatted output into the string array
		System.IO.File.WriteAllLines(@"/home/kevin/Kevin/school/CST117/workspace/OCA3/wordwMostVowels.txt", wordwMostVow);     //wordsMostVow array printed out to the text file      
	}
	protected void OnButton4Clicked(object sender, EventArgs e)
	{
		string input = System.IO.File.ReadAllText(@"/home/kevin/Kevin/school/CST117/workspace/OCA3/text_test.txt");     //input read from text file and placed into a string
		string[] strArray;      //array created to store string
		strArray = input.Split(' ');        //stringArray indices filled with string and cut off at space delimeter
		lowerCase(strArray);        //lower case method called
		alphabetically(strArray);        //alphabeticaly sort method called
		longestWord(strArray);        //longest word method called
		moistVowels(strArray);        //most vowels method called
	}
}
