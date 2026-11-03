
using System.ComponentModel;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;


public class Trampoline : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
 
    public float speedUp = 1f;


    void OnCollisionEnter2D(Collision2D other) {

        if(other.gameObject.tag =="Player")
        {
           var rb = other.gameObject.GetComponent<Rigidbody2D>(); 
           if(rb != null)
            {
                rb.linearVelocity= new Vector2(rb.linearVelocity.x,0f);
                rb.AddForce(Vector2.up*speedUp);
            }
          
        }
        
    }

}
