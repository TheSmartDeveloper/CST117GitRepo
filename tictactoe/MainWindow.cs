using System;
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

    protected void OnButton1Clicked(object sender, EventArgs e)
    {
        int[,] gameGrid = new int[3, 3];
        Random numRan = new Random();
        int arrayI = 0;
        int arrayJ = 0;

        while (gameGrid[0, 0] == 0 || gameGrid[0, 1] == 0 || gameGrid[0, 2] == 0 || gameGrid[1, 0] == 0 || gameGrid[1, 1] == 0 || gameGrid[1, 2] == 0 || gameGrid[2, 0] == 0 || gameGrid[2, 1] == 0 || gameGrid[2, 2] == 0)
        {
            arrayI = numRan.Next(0, 3);
            arrayJ = numRan.Next(0, 3);
            if (gameGrid[arrayI, arrayJ] == 0)
            {
                int result = numRan.Next(1, 3);
                gameGrid[arrayI, arrayJ] = result;
                Console.WriteLine("gameGrid[" + arrayI + "," + arrayJ + "] = " + result);
            }
        }

        String L1 = gameGrid[0, 0].ToString();
        String L2 = gameGrid[0, 1].ToString();
        String L3 = gameGrid[0, 2].ToString();
        String L4 = gameGrid[1, 0].ToString();
        String L5 = gameGrid[1, 1].ToString();
        String L6 = gameGrid[1, 2].ToString();
        String L7 = gameGrid[2, 0].ToString();
        String L8 = gameGrid[2, 1].ToString();
        String L9 = gameGrid[2, 2].ToString();
        label1.Text = (L1);
        label2.Text = (L2);
        label3.Text = (L3);
        label4.Text = (L4);
        label5.Text = (L5);
        label6.Text = (L6);
        label7.Text = (L7);
        label8.Text = (L8);
        label9.Text = (L9);
        if(L1 == L4 && L4 == L7)
        {
            label10.Text = (L1 + " is the winner");
        }
        else if(L2 == L5 && L5 == L8)
        {
            label10.Text = (L2 + " is the winner");
        }
        else if (L3 == L6 && L6 == L9)
        {
            label10.Text = (L3 + " is the winner");
        }
        else if (L1 == L2 && L2 == L3)
        {
            label10.Text = (L1 + " is the winner");
        }
        else if (L4 == L5 && L5 == L6)
        {
            label10.Text = (L4 + " is the winner");
        }
        else if (L7 == L8 && L8 == L9)
        {
            label10.Text = (L7 + " is the winner");
        }
        else if (L1 == L5 && L5 == L9)
        {
            label10.Text = (L1 + " is the winner");
        }
        else if (L3 == L5 && L5 == L7)
        {
            label10.Text = (L3 + " is the winner");
        }
        else
        {
            label10.Text = ("Well this is unexpected...");
        }
    }
}
