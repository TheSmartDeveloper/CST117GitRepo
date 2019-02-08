using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)                         //preloaded Class declared that builds GTK+ application
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)              //preloaded Class that exits program when window corner 'x' is clicked
    {
        Application.Quit();
        a.RetVal = true;
    }
   
	protected void OnButton1Clicked(object sender, EventArgs e)                 //class created when the calculate button is pressed, all math happens inside here
    {
       string text = entry1.Text;                                              //take input from the first textbox and convert to string, this is so that I can put it into the bool type later and check if it contains integers.
       double earthWeight;                                                     //double variable type to store the weight of an individual on earth NOT THE WEIGHT OF THE EARTH!!!
       bool result = double.TryParse(text, out earthWeight);                   //boolean variable type to express whether the user input is a double or not. If it is, the value gets put into earthWeight
       if(result == true && earthWeight >= 0)                                  //if bool result returns true, and the earthWeight variable is greater than or equal to 0 then do the math on the value
       {
    	   double marsWeight = (earthWeight / 9.81) * 3.711;                   //double variable type to store the weight of an individual on mars NOT THE WEIGHT OF MARS!!!
	       double weightRoundto3 = Math.Round(marsWeight, 3);                  //double var created to store marsWeight rounded to 3 decimal places. Ideally, this keeps the rounded answer and the true answer seperate to avoid any chance of overwriting the right data with the wrong data
    	   entry2.Text = (Convert.ToString(weightRoundto3));                   //double var 'weightRoundto3' converted back to a string and then printed into the second text box so user can see weight
       }
       else
       {
	       entry2.Text = ("You should put in a positive value");             //alternative so that if the user puts in anything other than a positive integer, the second text box will tell them to do so.
       }
    }
}
