using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class EnchantCollection : ScriptableObject {

    public List<EnchantObject> Enchants;

    public void CollectEnchant (EnchantObject enchant)
    {
        Debug.Log(enchant);
    }


}
