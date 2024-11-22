using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    public static Item exampleItem = new("Example", 00, "This is an example item. It holds no relation to me.");
    public class Item
    {
        public string name;
        /*The ID System is going to be how we separate different items.
        There'll be three different numbers for each ID
        - first number indicates the puzzle it's used on (1, 2, 3, or 4)
        - second number indicates which item it is within that puzzle
        An example would be the ID 24, which would be the 4th item in the 2nd puzzle */
        public int ID;
        //We'll prolly need a Unity Event system for the inspect thing, but we'll worry about that later
        public string inspectText;
        public Item(string name, int ID, string inspectText)
        {
            this.name = name;
            this.ID = ID;
            this.inspectText = inspectText;
        }
    }
}
