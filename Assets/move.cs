using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class move : MonoBehaviour
{

    Rigidbody rb;

    public Text countText;
    public Text winText;

    int count;
    public float speed;
    public float turnSpeed;
    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody>();

        count = 0;
        countText.text = "分數";
        winText.text = "";


    }

    // Update is called once per frame
    void Update()
    {
        
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");


        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);

    }

    void OnTriggerEnter(Collider other)
    {

        other.gameObject.SetActive(false);
        count++;

        countText.text = "分數:" + count.ToString();

        if (count >= 3)
        {
            winText.text = "You Win!";
        }

    }
}
