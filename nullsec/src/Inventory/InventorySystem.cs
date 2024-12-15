using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class InventorySystem
{
    public List <Item> items = new List <Item>() ;
    public void AddItem ( Item item )
    {
        items.Add( item );
        Console.WriteLine ($"{ item.name } added to inventory.");
    }
    public void UseItem ( string name , PlayerCharacter player )
    {
        foreach(Item item in items) {
            if (name == item.name) {
                items.Remove(item);
                break;
            }
        }
    }
}