
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Vector2 StartingPosition;

    public float PlatformSpeed = 1f;

    void Start()
    {
        StartingPosition = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
