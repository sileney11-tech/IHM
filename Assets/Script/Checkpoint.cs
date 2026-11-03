
using Unity.VisualScripting;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField]
    private int checkpointValue;

    public AudioSource audio;

    void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Feedback f = collision.gameObject.GetComponentInParent<Feedback>();
            if(f != null)
            {
                f.CoroutineGamepad(f.vibrationduration_CheckPoint);
            }
           /* if(audio != null)
            {
                audio.Play();
                Debug.Log("Audio Playing");
            }  
            */   
            collision.gameObject.GetComponentInParent<CheckpointReceiver>().nextCheckpoint(checkpointValue);
            Destroy(gameObject);
        }
    }
}
