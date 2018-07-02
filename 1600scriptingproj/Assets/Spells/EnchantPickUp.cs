using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnchantPickUp : MonoBehaviour {

    public EnchantObject Enchant;
    public EnchantCollection Collection;

    private void OnTriggerEnter(Collider obj)
    {
        Collection.CollectEnchant(Enchant);
    }

}
