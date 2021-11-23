using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this is a test, v1

public class camera_behavior : MonoBehaviour
{   
    //
    public float rotationDegreees = 0.1f;
    //
    public float movementSpeed = 12f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3 (horizontalInput, 0, verticalInput);

        // xy
        if(Input.GetKey(KeyCode.LeftArrow)){
            print("left key has been pressed");
            transform.Rotate(0.0f,-rotationDegreees, 0.0f);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            print("right key has been pressed");
            transform.Rotate(0.0f,rotationDegreees, 0.0f);
        }
        if(Input.GetKey(KeyCode.UpArrow)){
            print("up key has been pressed");
            transform.Rotate(-rotationDegreees,0.0f, 0.0f);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            print("down key has been pressed");
            transform.Rotate(rotationDegreees,0.0f, 0.0f);
        }

        // z
        if(Input.GetKey("z")){
            print("z key has been pressed");
            transform.Rotate(0.0f,0.0f, -rotationDegreees);
        }
        if(Input.GetKey("q")){
            print("q key has been pressed");
            transform.Rotate(0.0f,0.0f, rotationDegreees);
        }
        //movement requires to be updated to use transform.position (not translate)
        if(Input.GetKey("w")){
            print("w key has been pressed");
            //transform.Translate(0,0,Time.deltaTime * speed);
            transform.position = transform.position + new Vector3(movementSpeed * Time.deltaTime * horizontalInput,0, verticalInput * movementSpeed * Time.deltaTime);
            //transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, verticalInput * speed * Time.deltaTime, 0);
         }
        if(Input.GetKey("a")){
            print("a key has been pressed");
            transform.position = transform.position + new Vector3(movementSpeed * Time.deltaTime * horizontalInput,0,0 );
        }
        if(Input.GetKey("x")){
            print("s key has been pressed");
            transform.position = transform.position + new Vector3(0,0, -verticalInput * movementSpeed * Time.deltaTime);
        }
        if(Input.GetKey("d")){
            print("d key has been pressed");
            transform.position = transform.position + new Vector3(movementSpeed * Time.deltaTime * horizontalInput,0,0 );
            
        }

        // // up
        // if(Input.GetKey("e")){
        //     print("e key has been pressed");
        //     //transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, verticalInput * speed * Time deltaTime, 0);
        // }
        // //down
        // if(Input.GetKey("c")){
        //     print("c key has been pressed");
        //     //transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, verticalInput * speed * Time.deltaTime, 0);
        // }
        Debug.Log(transform.position);
    }
}
