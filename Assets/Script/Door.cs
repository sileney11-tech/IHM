
using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour
{

    public float intervalleToOpenMenu = 2f;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag =="Player")
        {
            //GameManager._instance.CharacterWon();
            SoundManager.PlaySound(SoundType.VICTORY_GAME);
            StartCoroutine(Bravo(intervalleToOpenMenu));
            
            
        }     
    }

    IEnumerator Bravo(float duration)
    {
        
       yield return new WaitForSeconds(duration); 
       GameManager._instance.OpenMenu(); 
       Debug.Log("Fini");
       
    }
}
