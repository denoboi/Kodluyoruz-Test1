using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public Text coinText;

    private void Start()
    {
        CoinManager.Instance.AddCoin(this);
    }
    private void OnDestroy()
    {
        CoinManager.Instance.RemoveCoin(this);
    }

    public void PickupCoin()
    {
        EventManager.OnCoinPickUp.Invoke();
        Destroy(gameObject);
    }

    
    
}
