/*
    Name: Kevin George
    Teacher: Prof. Gordon
    Class: CST117
    Date: Sun, Oct 28th, 2018
*/
using System;
using System.IO;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

	protected void OnButton3Clicked(object sender, EventArgs e)
	{
		string newCar = "\n" + entry4.Text;
        System.IO.File.AppendAllText(@"/home/kevin/Kevin/school/CST117/workspace/ICA6/inventory.txt", newCar);
		string test = System.IO.File.ReadAllText(@"/home/kevin/Kevin/school/CST117/workspace/ICA6/inventory.txt");
		label5.LabelProp = (test);
	}

	protected void OnButton4Clicked(object sender, EventArgs e)
	{
		string test = System.IO.File.ReadAllText(@"/home/kevin/Kevin/school/CST117/workspace/ICA6/inventory.txt");
		label5.LabelProp = (test);

	}
}
