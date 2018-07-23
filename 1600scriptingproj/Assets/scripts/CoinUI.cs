using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinUI : MonoBehaviour {

    public IntData CoinCollection;
    public Text CoinText;

    private void Start()
    {
        CoinText.text = GetComponent<Text>().ToString();
    }

    // Update is called once per frame
    private void Update () {
        CoinText.text = CoinCollection.Value.ToString();
	}
}
