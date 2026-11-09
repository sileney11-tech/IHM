using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text WinText;

    public TMP_Text MortText;

    public GameObject menu;
    public GameObject canvasTest;

    public void WinTextEnable()
    {
        WinText.text = "T'as gagné ! Bravo !";
        Debug.Log(WinText.text);
    }

    public void MortTextEnable()
    {
        MortText.text = MortText.text + "Héhé  ";
        Debug.Log(MortText.text);
    }

    public void OuvrirMenu()
    {
        menu.SetActive(true);
        canvasTest.SetActive(false);
    }

    public void FermerMenu()
    {
        menu.SetActive(false);
        canvasTest.SetActive(true);
    }

    public void Quitter()
    {
        Application.Quit();
    }
}
