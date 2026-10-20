
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    public float speedUp = 10f;


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
}
