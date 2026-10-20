
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
                rb.AddForce(new Vector2(0,speedUp));
            }
          
        }
        
    }

    IEnumerator PadVibration(Gamepad pad, float duration)
    {
       pad.SetMotorSpeeds(0.01f,0.01f);
       yield return new WaitForSeconds(duration);   
       pad.SetMotorSpeeds(0f,0f);
    }
}
