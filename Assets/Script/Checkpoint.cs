
using Unity.VisualScripting;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField]
    private int checkpointValue;




    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Feedback f = collision.gameObject.GetComponentInParent<Feedback>();
            if(f != null)
            {   
                if(f.pad != null)
                {
                    f.CoroutineGamepad(f.vibrationduration_CheckPoint);
                }
                f.StartAudio();
            }
            collision.gameObject.GetComponentInParent<CheckpointReceiver>().nextCheckpoint(checkpointValue);
            Destroy(gameObject);
        }
    }
}
