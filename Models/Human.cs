using System;
class Human
{
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity; 
    private int health;

    public int Health
    {
        get
        {
            return health;
        }
    }

    public Human(string name)
    {
        Name = name;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3; 
        this.health = 100;
    }

    public Human(string name, int strength, int intelligence, int dexterity, int health)
    {
        Name = name;
        Strength = strength;
        Intelligence= intelligence;
        Dexterity = dexterity; 
        this.health = health;
    }
    public int Attack(Human target)
    {
        int damage = Strength * 5;
        target.health -= damage; 
    }
}