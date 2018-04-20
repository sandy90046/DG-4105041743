using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();

    }
    public float speed;
    Rigidbody rigidbody;

    // Update is called once per frame
    void Update()
    {
        rigidbody.velocity = transform.forward * speed;
    }
}
