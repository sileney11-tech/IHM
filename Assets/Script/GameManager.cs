
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public static GameManager _instance;

    public void YouWin()
    {
        Debug.Log("T'as gagné ! Bravo !");
    }

}
