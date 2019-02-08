/*
    Name: Kevin George
    Teacher: Prof. Gordon
    Class: CST117
    Date: Sun, Oct 28th, 2018
*/
using System;
using Gtk;

namespace ICA6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();
            MainWindow win = new MainWindow();
            win.Show();
            Application.Run();
        }
    }
}
