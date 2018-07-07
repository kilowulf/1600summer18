using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorClassBase : MonoBehaviour
{

    public Warrior AnyWarrior;
    

    // Attribute Mod Vars
    public int Strength = 2;
    public int Constitution = 2;
    public int Dexterity = 1;

    // Stat Mod Vars
    public float HealthBonus = 100.00f;
    public float Stamina = 100.00f;

    // Skill Mod Vars
    public float WeaponOneHand = 10.00f;
    public float Shield = 10.00f;
    public float UseArmor = 10.00f;
    public float DodgeRoll = 5.00f;
    public float Resolve = 10.00f;
    
    //Inventory
    public int GoldCoins = 0;


}
