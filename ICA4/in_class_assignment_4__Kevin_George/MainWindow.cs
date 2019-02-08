/*
    Name: Kevin George
    Teacher: Prof. Gordon
    Class: CST117
    Date: Wed, Sep 26th, 2018
*/
using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)                         //preloaded class to open gui
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)              //preloaded class to handle when user presses the window box 'X'
    {
        Application.Quit();
        a.RetVal = true;
    }

	protected void ConvertInput(object sender, EventArgs e)                     //class to handle clicking of the GUI button
	{
		//entry4, entry5, entry6, entry7, entry8
		string Input;                                                           //A string var is created and the input from the entry4 text box is put into it
		Input = entry4.Text;                                                    //
		long secondsIn = 0;                                                     //int var created to take in the number of seconds a user input
        bool checkInput = long.TryParse(Input, out secondsIn);                  //check to see if Input can be an int, if so it will be output to secondsIn otherwise nothing will happen
		if (checkInput == true && secondsIn >= 0)                               //using the bool var to initialize the rest of the program
        {
            long days = 0;
			long hours = 0;                                                      //time vars initialized to 0
			long minutes = 0;
			long seconds = 0;

			const long oneDayinSeconds = 86400;
			const long oneHourinSeconds = 3600;                                 //conversion standards initialized to their values
			const long oneMinuteinSeconds = 60;

			if (secondsIn >= oneDayinSeconds)                                   //cascading if statements designed to go in order when days is calculated (or skipped) then hours will be calculated (or skipped) and so on until only the seconds are left
            {
                days = secondsIn / oneDayinSeconds;
                secondsIn = secondsIn % oneDayinSeconds;
				entry5.Text = (Convert.ToString(days));
            }
            else
            {
				entry5.Text = (Convert.ToString(days));
            }
            if (secondsIn >= oneHourinSeconds)
            {
                hours = secondsIn / oneHourinSeconds;
                secondsIn = secondsIn % oneHourinSeconds;
				entry6.Text = (Convert.ToString(hours));
            }
            else
            {
				entry6.Text = (Convert.ToString(hours));
            }
            if (secondsIn >= oneMinuteinSeconds)
            {
                minutes = secondsIn / oneMinuteinSeconds;
                secondsIn = secondsIn % oneMinuteinSeconds;
				entry7.Text = (Convert.ToString(minutes));
            }
            else
            {
				entry7.Text = (Convert.ToString(minutes));
            }
            if (secondsIn < oneMinuteinSeconds)
            {
                seconds = secondsIn;
				entry8.Text = (Convert.ToString(seconds));
            }
            else
            {
				entry8.Text = (Convert.ToString(seconds));
            }

        }
		else
		{                                                                       //warning message when a user puts in bad data
			entry5.Text = ("Please");
            entry6.Text = ("use");
            entry7.Text = ("positive");
            entry8.Text = ("integers");
		}
	}
}
