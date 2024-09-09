using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed;

    void Start()
    {

    }


    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * Speed;
        
        movement = new Vector3(0f,Input.GetAxis("Vertical"),0f);
        transform.position += movement * Time.deltaTime * Speed;
        
        if (Input.GetAxis("Horizontal") > 0f)
        {
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }

        if (Input.GetAxis("Horizontal") < 0f)
        {
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        
        if (Input.GetAxis("Vertical") > 0f)
        {
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        
        if (Input.GetAxis("Vertical") < 0f)
        {
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
    }
}


