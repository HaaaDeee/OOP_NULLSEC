using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public abstract class Item
{
    public abstract string name { get ; }
    public abstract void Use ( PlayerCharacter player );
}
