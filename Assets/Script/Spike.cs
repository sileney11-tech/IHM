using UnityEngine;

public class Spike : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponentInParent<CheckpointReceiver>().resetPosition();
        }
    }
}
