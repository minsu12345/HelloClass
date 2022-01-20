using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    public Rigidbody myrigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myrigidbody.AddForce(0, 500, 0);
    }
}
