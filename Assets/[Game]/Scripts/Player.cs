using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rigidbody;
    Rigidbody Rigidbody { get { return (rigidbody == null)}? rigidbody = GetComponent<Rigidbody>(): rigidbody; }}
}
