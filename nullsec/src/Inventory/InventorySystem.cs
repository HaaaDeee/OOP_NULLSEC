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
    public void UseItem ( Item item , PlayerCharacter player )
    {
        item.Use( player );
        items.Remove( item );
    }
}