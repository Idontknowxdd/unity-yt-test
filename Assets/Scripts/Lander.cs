using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Lander : MonoBehaviour
{
    private Rigidbody2D landerRigidbody2D;

      private void Awake()
    {
        landerRigidbody2D = GetComponent<Rigidbody2D>();
    }
   

      private void FixedUpdate()
    {
        if (Keyboard.current.upArrowKey.IsPressed())
        {
            float force = 700f;
            landerRigidbody2D.AddForce(force * transform.up * Time.deltaTime);
        }

        if (Keyboard.current.leftArrowKey.IsPressed())
        {
            float TurnSpeed = +100F;    
            landerRigidbody2D.AddTorque(TurnSpeed * Time.deltaTime);
        }    

         if (Keyboard.current.rightArrowKey.IsPressed())
        {
            float TurnSpeed = -100F;    
            landerRigidbody2D.AddTorque(TurnSpeed * Time.deltaTime);
        } 
    }
}
