
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public static GameManager _instance;

    public void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public UIManager _uiManager;

    public void CharacterKilled()
    {
        _uiManager.MortTextEnable();
        Debug.Log("Mort");
    }

    public void CharacterWon()
    {
        _uiManager.WinTextEnable();
        Debug.Log("Gagné");
    }

  
}
