using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class InventorySystem
{
    private List <Item > _items = new List <Item >() ;
    public void AddItem ( Item item )
    {
        _items . Add( item );
        Console . WriteLine ($"{ item . Name }␣ added ␣to␣ inventory .");
    }
    public void UseItem ( Item item , PlayerCharacter player )
    {
        item .Use ( player );
        _items . Remove ( item );
    }
}