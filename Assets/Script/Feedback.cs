using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;

public class Feedback : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public Gamepad pad;

   private Rigidbody2D rb;

   [Header("Vibration")]
   public float vibrationduration = 0.5f;

   public float vibrationStrenghX = 0.01f;

   public float vibrationStrenghY = 0.01f;
   

   void Awake()
    {
        pad = Gamepad.current;
        rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ground" || other.gameObject.tag == "Trampoline")
        {
            if(rb != null)
            {
                StartCoroutine(PadVibration(pad,vibrationduration));
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
