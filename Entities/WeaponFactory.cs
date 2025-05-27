using System;
using System.Collections.Generic;

public class WeaponFactory
{
    private List<Weapon> weapons = new List<Weapon>();

    public Weapon CreateWeapon(string name)
    {
        Weapon newWeapon;

        switch (name.ToLower())
        {
            case "m16":
                newWeapon = new Weapon("M16", "Colt", 29);
                break;
            case "ak47":
                newWeapon = new Weapon("AK47", "Kalashnikov", 30);
                break;
            default:
                newWeapon = new Weapon("Basic Gun", "Generic", 10);
                break;
        }

        weapons.Add(newWeapon);
        return newWeapon;
    }

    public List<Weapon> GetAllWeapons()
    {
        return weapons;
    }
}