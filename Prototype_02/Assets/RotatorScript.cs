using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RotatorScript : MonoBehaviour
{
    public float rotationSpeed = 0.1f;
    //public GameObject loop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        this.GetComponent<Transform>().Rotate(0f, rotationSpeed, 0f);
        //loop.transform.Rotate(0f, 0f, rotationSpeed);

        /*if (Input.GetKey(KeyCode.R))
        {
          this.GetComponent<Transform>().Rotate(0f, rotationSpeed, 0f);
        }
         if (Input.GetKey(KeyCode.T))
        {
           this.GetComponent<Transform>().Rotate(0f, -rotationSpeed, 0f);
        }*/

    }

}
