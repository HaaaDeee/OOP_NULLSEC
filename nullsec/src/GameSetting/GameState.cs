using System ;
using System .IO;
using System . Runtime . Serialization . Formatters . Binary ;

[ Serializable ]
public class GameState
{
    public PlayerCharacter? Player { get ; set ; }
    public List<Item>? InventoryItems { get ; set ; }
    public int PlayerLevel { get ; set ; }
}