using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class EnemyAI
{
    private IAttackStrategy _attackStrategy ;
    public EnemyAI ( IAttackStrategy strategy )
    {
        _attackStrategy = strategy ;
    }
    public void SetAttackStrategy ( IAttackStrategy strategy )
    {
        _attackStrategy = strategy ;
    }
    public void ExecuteAttack ( Enemy enemy , PlayerCharacter player)
    {
        _attackStrategy.ExecuteAttack( enemy , player );
    }
}