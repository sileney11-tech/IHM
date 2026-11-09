using UnityEditorInternal;
using UnityEngine;

public class Door : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag =="Player")
        {
            GameManager._instance.CharacterWon();
            Debug.Log("Touche");
        }     
    }
}
