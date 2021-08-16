using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    public Rigidbody Rigidbody // { get { return (rigidbody == null) ? rigidbody = GetComponent<Rigidbody>(): rigidbody; } }

    {
        get
        {
            if (rb == null)
            {
                rb = GetComponent<Rigidbody>();
            }

            return rb;

        }
    }

    public float moveSpeed;

    private int point = 0;

    private void FixedUpdate()
    {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //Rigidbody.AddForce(input * MoveSpeed * Time.deltaTime);

        Rigidbody.velocity = input * moveSpeed * Time.fixedDeltaTime;

    }

    private void OnTriggerEnter(Collider other)
    {
        Coin coin = other.GetComponent<Coin>();
        if(coin != null)
        {
            point++;
            coin.PickupCoin(point);  // int ve float vs. null olmaz hicbir zaman bunlarin default bir degeri vardir. 
                                     // float ve integerlar icin default 0, bool'lar icin false, stringler icin empty.
            
        
        }
    }
}
