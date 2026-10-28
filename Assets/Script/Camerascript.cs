using System;
using UnityEngine;

public class Camerascript : MonoBehaviour
{
    private Camera _mainCamera;
    [SerializeField]
    private GameObject cible;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        _mainCamera.transform.position = new Vector3(cible.transform.position.x, cible.transform.position.y, -10);
    }
}
