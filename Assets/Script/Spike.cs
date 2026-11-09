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
                if(f.pad !=null)
                {
                f.CoroutineGamepad(f.vibrationduration_Spike);
                }
            }
            SoundManager.PlaySound(SoundType.DEAD);
            collision.gameObject.GetComponentInParent<CheckpointReceiver>().resetPosition();
            GameManager._instance.CharacterKilled();
        }
    }
}
