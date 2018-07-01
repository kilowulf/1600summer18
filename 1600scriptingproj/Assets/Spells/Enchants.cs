using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enchants : MonoBehaviour {

	public enum SpellType
    {
        FireEnchant,
        AirEnchant,
        WaterEnchant,
        EarthEnchant,   
        SpiritEnchant,
    }

    public SpellType CurrentEnchant;
    public EnchantObject[] EnchantObjects;

    

    void Update()
    {   // set behaviors for each case weapon
        switch (CurrentEnchant)
        {
            case SpellType.FireEnchant:
                // consoles weapon name
                Debug.Log(EnchantObjects[0].name);
                // consoles damage level
                Debug.Log(EnchantObjects[0].DoDamage());
                break;

            case SpellType.AirEnchant:
                Debug.Log(EnchantObjects[1].name);
                Debug.Log(EnchantObjects[1].DoDamage());
                break;

            case SpellType.WaterEnchant:
                Debug.Log(EnchantObjects[2].name);
                Debug.Log(EnchantObjects[2].DoDamage());
                break;

            case SpellType.EarthEnchant:
                Debug.Log(EnchantObjects[3].name);
                Debug.Log(EnchantObjects[3].DoDamage());
                break;

            case SpellType.SpiritEnchant:
                Debug.Log(EnchantObjects[4].name);
                Debug.Log(EnchantObjects[4].DoDamage());
                break;
        }
    }

}
