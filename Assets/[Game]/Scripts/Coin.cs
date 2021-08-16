using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public Text coinText;

    public void PickupCoin(int point)
    {
        
        coinText.text = "Score " + point;
        Destroy(gameObject);
    }
}
