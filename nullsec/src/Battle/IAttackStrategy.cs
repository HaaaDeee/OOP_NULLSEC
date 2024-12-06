using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public interface IAttackStrategy
{
    void ExecuteAttack ( Enemy enemy , PlayerCharacter player );
}