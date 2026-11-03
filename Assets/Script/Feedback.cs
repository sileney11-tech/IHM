using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;




public class Feedback : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public Gamepad pad;

   private Rigidbody2D rb;

   [Header("Audio Clip")]

   public AudioClip AudioCheckPoint;

   [SerializeField] public AudioSource source;

   

   [Header("Vibration")]
   public float vibrationduration_Spike = 0.1f;

   public float vibrationduration_CheckPoint = 0.3f;

   public float vibrationStrenghX = 0.01f;

   public float vibrationStrenghY = 0.01f;
   

   void Awake()
    {
        pad = Gamepad.current;
        rb = GetComponent<Rigidbody2D>();
        source = GetComponent<AudioSource>();
        
        
    }


    /*

    void OnColliderEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Spike" || other.gameObject.tag == "Trampoline" )
        {
            if(rb != null)
            {
                CoroutineGamepad;
            }
            
        }

    }
    */

    public void CoroutineGamepad(float duration)
    {
       StartCoroutine(PadVibration(pad,duration));
    }

    public void StartAudio()
    {
        if(source != null && AudioCheckPoint != null)
        {
            //AudioSource.PlayOneShot(AudioCheckPoint);
            Debug.Log("Audio Playing");
        }
        
    }

     IEnumerator PadVibration(Gamepad pad, float duration)
    {
        
       pad.SetMotorSpeeds(vibrationStrenghX, vibrationStrenghY);
       yield return new WaitForSeconds(duration);   
       pad.SetMotorSpeeds(0f,0f);
    }

}
