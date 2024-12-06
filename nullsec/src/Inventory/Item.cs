using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public abstract class Item
{
    public abstract string Name { get ; }
    public abstract void Use ( PlayerCharacter player );
}
