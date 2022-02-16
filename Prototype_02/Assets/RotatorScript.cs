using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RotatorScript : MonoBehaviour
{
    public float rotationSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // FixedUpdate(): No matter what would be the computer frame rate, the update function would act the same.
    // OR, use this function with every line of code that you write: *Time.deltaTime()
    void FixedUpdate()
    {

       if (Input.GetKey(KeyCode.R))
        {
          this.GetComponent<Transform>().Rotate(0f, rotationSpeed, 0f);
        }
         if (Input.GetKey(KeyCode.T))
        {
           this.GetComponent<Transform>().Rotate(0f, -rotationSpeed, 0f);
        }
     
    }
    /*public void Rotate( InputAction.CallbackContext context)
    {
        Debug.Log("Input detected");
        this.GetComponent<Transform>().Rotate(0f, rotationSpeed, 0f);
    }
    public void Rotate2()
    {
        this.GetComponent<Transform>().Rotate(0f, rotationSpeed, 0f);
    }*/
}
