using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
   

   

    private Vector3 offset;
    private Vector3 pivotOffset;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
       

        //set the offset of the camera based on the player
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        //Get the cameras transform position to be that of the players transform position
        transform.position = player.transform.position + offset;

    }
}
