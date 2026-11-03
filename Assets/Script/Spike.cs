using UnityEngine;

public class Spike : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //feedback
            Feedback f = collision.gameObject.GetComponentInParent<Feedback>() ;
            if(f != null)
            {
                f.CoroutineGamepad(f.vibrationduration_Spike);
            }
            collision.gameObject.GetComponentInParent<CheckpointReceiver>().resetPosition();
        }
    }
}
