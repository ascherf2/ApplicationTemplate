using System;

namespace ApplicationTemplate.Services;

/// <summary>
///     You would need to inject your interfaces here to execute the methods in Invoke()
///     See the commented out code as an example
/// </summary>
public class MainService : IMainService
{
    
    public MainService()
    {
        
    }

    public void Invoke()
    {
        var weapon = new Weapon();
        weapon.Name = "Sword";
        weapon.Damage = 10;

        var armor = new Armor();
        armor.Name = "Shirt";
        armor.Protection = 5;

        var player = new Player(weapon, armor);
        player.Name = "Gronk";

        var monster = new Monster(weapon, armor);
        monster.Name = "Minotaur";

        player.Attack(monster);
       
    }
}
public class Monster
{
    public Monster(Weapon weapon, Armor armor)
    { 
        throw new NotImplementedException();
    }

    public string Name { get; set; }

}
public class Player
{ 
    public Player(Weapon weapon, Armor armor)
    { 
        throw new NotImplementedException();
    }

    public string Name { get; set; }

}

public class Armor
{
    public string Name { get; set; }
    public string Protection { get; set; }
}

public class Weapon
{
    public string Name { get; set; }
    public int Damage { get; set; }
}
