using System;
public class PlayerCharacter
{
    private static PlayerCharacter? instance ; // Singleton instance
    public string CharacterName { get ; set ; }
    public string TechTree { get ; set ; } // Tech Trees : Technician , Hacker , Enforcer , Infiltrator
    public int Level { get ; set ; }
    public int MaxSkillPoints { get ; set ; }
    public int SkillPoints { get ; set ; }
    public int MaxHealth { get ; set ; }
    public int Health { get ; set ; }
    public int MaxAttack { get ; set ; }
    public int Attack { get ; set ; }
    public int MaxDefense { get ; set ; }
    public int Defense { get ; set ; }
    public InventorySystem inventory { get ; set ; }

    
    int temp = 0;
    // Private constructor to prevent instantiation from outside
    private PlayerCharacter( string characterName , string techTree)
    {
        CharacterName = characterName ;
        TechTree = techTree ;
        Level = 1;
        MaxSkillPoints = 0;
        SkillPoints = MaxSkillPoints;
        MaxHealth = 100;
        MaxAttack = 10;
        MaxDefense = 5;
        switch(TechTree.ToLower()) {
            case "technician":
                MaxAttack += 5;
                MaxHealth += 10;
                break;
            case "hacker":
                MaxAttack += 5;
                MaxDefense += 5;
                MaxHealth -= 25;
                break;
            case "enforcer":
                MaxAttack -= 5;
                MaxDefense += 5;
                MaxHealth += 20;
                break;
            case "infiltrator":
                MaxAttack += 10;
                MaxDefense = 0;
                MaxHealth -= 10;
                break;
            default:
                break;
        }
        Health = MaxHealth;
        Attack = MaxAttack;
        Defense = MaxDefense;
        instance = this;
        inventory = new InventorySystem();
    }

    
    private PlayerCharacter()
    {
        CharacterName = null ;
        TechTree = null ;
        Level = 1;
        MaxSkillPoints = 0;
        SkillPoints = MaxSkillPoints;
        MaxHealth = 100;
        MaxAttack = 10;
        MaxDefense = 5;
        Health = MaxHealth;
        Attack = MaxAttack;
        Defense = MaxDefense;
        instance = this;
        inventory = new InventorySystem();
    }

    // Singleton instance retrieval method
    public static PlayerCharacter GetInstance( string characterName , string techTree )
    {
        if( instance == null )
        {
            instance = new PlayerCharacter( characterName, techTree );
        }
        return instance ;
    }

    
    public static PlayerCharacter GetInstance( )
    {
        if( instance == null )
        {
            instance = new PlayerCharacter( );
        }
        return instance ;
    }

    // Level up method , increases level and grants skill points
    public void LevelUp()
    {
        Level++;
        int[] ValidLevels = [1,2,5,6,10,12,15,17,20,23,25,28,30];
        bool isValid = false;
        for(int i=0; i<ValidLevels.Length; i++) {
            if(Level == ValidLevels[i] || Level%5 == 0) {
                isValid = true;
                break;
            }
        }
        if(isValid) {SkillPoints++;}
        Console.WriteLine($"{ CharacterName } leveled up to { Level }! Skill Points : { SkillPoints }");
    }
    // Method to allocate skill points to increase stats
    public void AllocateSkillPoint( string skill )
    {
        if(SkillPoints > 0)
        {
            switch(skill.ToLower())
            {
                case "health":
                MaxHealth += 10;
                Health = MaxHealth;
                Console.WriteLine($"\n{ CharacterName } increased Health to { Health }");
                SkillPoints --;
                break ;
                case "attack":
                MaxAttack += 2;
                Attack = MaxAttack;
                Console.WriteLine($"\n{ CharacterName } increased Attack to { Attack }");
                SkillPoints --;
                break ;
                case "defense":
                MaxDefense += 2;
                Defense = MaxDefense;
                Console.WriteLine($"\n{ CharacterName } increased Defense to { Defense }");
                SkillPoints --;
                break ;
                default :
                Console.WriteLine("\nInvalid skill choice!");
                return ;
            }
        }
        else
        {
            Console.WriteLine("\nNo skill points available.");
        }
    }
    // Method to display the character’s current status
    public void DisplayStatus()
    {
        Console.WriteLine($"Name : { CharacterName }");
        Console.WriteLine($"Tech Tree : {TechTree }");
        Console.WriteLine($"Level : { Level }");
        Console.WriteLine($"Health : { Health }");
        Console.WriteLine($"Attack : {Attack }");
        Console.WriteLine($"Defense : { Defense }");
        Console.WriteLine($"Skill Points : { SkillPoints }");
    }
    // Method for taking damage
    public void TakeDamage(int damage )
    {
        int damageTaken = Math.Max( damage - Defense , 0);
        Health -= damageTaken ;
        Console . WriteLine($"{ CharacterName } took { damageTaken } damage. Health is now { Health }");
        if( Health <= 0)
        {
            Console . WriteLine($"{ CharacterName } has been defeated.");
            // Handle character defeat logic
        }
    }
    // Method for attacking an enemy
    public void AttackEnemy(Enemy enemy)
    {
        Console . WriteLine($"{ CharacterName } attacks with { Attack } power!");
        // Additional logic for interacting with enemy
        Random random = new Random();
        int critical = random.Next(0, 100);
        if( critical < 5)
        {
            Console . WriteLine("Critical hit!");
            enemy.Health -= Attack * 2;
        }
        else
        {
            enemy.Health -= Attack ;
        }
    }

    public void getBuff(string type, int buff)
    {
        switch(type.ToLower())
        {
            case "health":
                Math.Max(Health += buff, MaxHealth);
                Health += buff;
                inventory.UseItem("Health Boost", instance);
                break;
            case "attack":
                Attack += buff;
                inventory.UseItem("Attack Boost", instance);
                Console.WriteLine($"{CharacterName} increased Attack to {Attack}");
                break;
            case "defense":
                Defense += buff;
                inventory.UseItem("Defense Boost", instance);
                Console.WriteLine($"{CharacterName} increased Defense to {Defense}");
                break;
            default:
                Console.WriteLine("Invalid buff type.");
                return;
        }
    }

    public void DisableBuff() {
        Health = MaxHealth;
        Attack = MaxAttack;
        Defense = MaxDefense;
    }

    public void RewardItem() {
        Random random = new Random();
        int rand = random.Next(0, 100);
        if(rand < 50) {
            rand = random.Next(1, 2);
            switch(rand) {
                case 1:
                    inventory.AddItem(new AttackBoost());
                    break;
                case 2:
                    inventory.AddItem(new HealthBoost());
                    break;
                default:
                    break;
            }
        }
    }
}