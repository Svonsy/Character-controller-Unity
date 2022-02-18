using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public GameObject player;
    public float playerSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        if (Input.GetKey("w"))
            player.transform.position += transform.forward * playerSpeed * Time.deltaTime;
        if (Input.GetKey("s"))
            player.transform.position -= transform.forward * playerSpeed * Time.deltaTime;
        if (Input.GetKey("a"))
            player.transform.position -= transform.right * playerSpeed * Time.deltaTime;
        if (Input.GetKey("d"))
            player.transform.position += transform.right * playerSpeed * Time.deltaTime;

    }



}
