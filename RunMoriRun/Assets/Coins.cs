using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public TextMeshProUGUI textCoins;
    private float coin = 0;
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Coin") {
            coin++;
            textCoins.text = coin.ToString();
            Destroy(other.gameObject);
        }
    }
}
