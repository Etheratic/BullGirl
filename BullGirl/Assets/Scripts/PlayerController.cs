using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public Rigidbody rb;
    public bool isTalking;
    Color originalColour;
    bool resetting = false;
    public GameObject resetPoint;


    private void Start()
    {

        //setting up reset point
        resetPoint = GameObject.Find("Reset Point");
        originalColour = GetComponent<Renderer>().material.color;
    }

    private void Update()
    {
        //detect movement inputs
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        //apply force
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(movement * moveSpeed);
    }

}

   
   