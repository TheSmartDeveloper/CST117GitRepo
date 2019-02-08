/*
    Kevin George
    Prof. Gordon
    CST-117
    11-21-2018
*/
using System;
using System.IO;
using Gtk;
namespace ICA6
{
    public class InventoryManager
    {
        public InventoryManager()
        {
        }

        public string NewItem(String newCar, String amountToAdd, String price) //FINISHED
        {
            String[] itemArray = new String[3];
            itemArray[0] = newCar;
            itemArray[1] = amountToAdd;
            itemArray[2] = price;
            String printOut = "\n" + itemArray[0].ToString() + " " + itemArray[1].ToString() + " " + itemArray[2].ToString();
            System.IO.File.AppendAllText(@"/home/kevin/Kevin/school/CST117/workspace/ICA6/inventory.txt", printOut);  //read file
            string test = System.IO.File.ReadAllText(@"/home/kevin/Kevin/school/CST117/workspace/ICA6/inventory.txt"); //put contents of file into a string
            return test; //display the result
        }

        public string RemoveItem(string itemToRemove)
        {
            string fromData = System.IO.File.ReadAllText(@"/home/kevin/Kevin/school/CST117/workspace/ICA6/inventory.txt"); //read file into a string
            if (fromData.Contains(itemToRemove)) //if the item exists in the string
            {

                fromData = fromData.Replace(itemToRemove, ""); //replace the item with an empty area
                System.IO.File.WriteAllText(@"/home/kevin/Kevin/school/CST117/workspace/ICA6/inventory.txt", fromData); //write the string back out to the file overwriting whatever was already there
                return "item: " + itemToRemove + " was removed from file"; //let user know that the item was removed
            }
            else
            {
                return "item does not exist and cannot be removed from file"; //otherwise let them know that if they are attempting to remove an item that does not already exist then it can't be done
            }
        }
        public String ReStockItem(String itemtoAdd, String amountToAdd, String price)
        {
            String[] itemArray = new String[3];
            itemArray[0] = itemtoAdd.Split(' ')[0] + " " + itemtoAdd.Split(' ')[1];
            itemArray[1] = amountToAdd;
            itemArray[2] = price;

            string fromData = System.IO.File.ReadAllText(@"/home/kevin/Kevin/school/CST117/workspace/ICA6/inventory.txt"); //read file into a string
            if (fromData.Contains(itemtoAdd)) //if the item exists in the string
            {

                string change = itemArray[0].ToString() + " " + itemArray[1].ToString() + " " + itemArray[2].ToString();
                fromData = fromData.Replace(itemtoAdd, change); //replace the item with an empty area
                System.IO.File.WriteAllText(@"/home/kevin/Kevin/school/CST117/workspace/ICA6/inventory.txt", fromData); //write the string back out to the file overwriting whatever was already there
                return "item: " + itemtoAdd + " was increased to " + amountToAdd; //let user know that the item was removed
            }
            else
            {
                return "item does not exist and needs to be added to the file"; //otherwise let them know that if they are attempting to remove an item that does not already exist then it can't be done
            }
        }

        public string DisplayItem()//FINISHED
        {
            string seeItems = System.IO.File.ReadAllText(@"/home/kevin/Kevin/school/CST117/workspace/ICA6/inventory.txt"); //read file into a string
            return seeItems; //return the items to be displayed
        }

        public string FindItem(string searchTerm)
        {
            string fromData = System.IO.File.ReadAllText(@"/home/kevin/Kevin/school/CST117/workspace/ICA6/inventory.txt"); //read file into a string
            if (fromData.Contains(searchTerm))  //if the item exists in the string
            {
                return searchTerm + " exists in file";   //let the user know that the item is there
            }
            else
            {
                return searchTerm + " does not exist in file"; //let the user know that the item is not there
            }
        }
    }
}
