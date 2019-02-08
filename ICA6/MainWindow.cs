/*
    Name: Kevin George
    Teacher: Prof. Gordon
    Class: CST117
    Date: Sun, Oct 28th, 2018
*/
using System;
using System.IO;
using Gtk;
using ICA6;

public partial class MainWindow : Gtk.Window
{
    InventoryManager carList = new InventoryManager();
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
        string amount = entry2.Text;
        string price = entry3.Text;
        string addItem = carList.NewItem(newCar, amount, price);
		label5.LabelProp = (addItem);
	}

	protected void OnButton4Clicked(object sender, EventArgs e)
	{
        string printOut = carList.DisplayItem();
		label5.LabelProp = (printOut);

	}

    protected void OnRestockClicked(object sender, EventArgs e)
    {
        string addCar = entry4.Text;
        string amount = entry2.Text;
        string price = entry3.Text;
        string printOut = carList.ReStockItem(addCar, amount, price);
        label5.LabelProp = (printOut);
    }

    protected void OnDeleteClicked(object sender, EventArgs e)
    {
        string loseCar = "\n" + entry4.Text;
        string printOut = carList.RemoveItem(loseCar);
        label5.LabelProp = (printOut);
    }

    protected void OnSearchClicked(object sender, EventArgs e)
    {
        string findCar = "\n" + entry4.Text;
        string printOut = carList.FindItem(findCar);
        label5.LabelProp = (printOut);
    }
}
