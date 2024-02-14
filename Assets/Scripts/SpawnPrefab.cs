using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefab : MonoBehaviour
{
    //minions spawn
    public GameObject myPrefab;
    //add folder
    public Transform minions; 
    private bool isSpawning;
    private Camera cam; //camera reference


    void Start()
    {
        isSpawning = true;
        cam = Camera.main;
    }

    public void spawn() {

        Debug.Log("instiante");

        Vector2 mousePos= cam.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(myPrefab, mousePos, Quaternion.identity, minions.transform);
        }
        
    }

    void Update()
    {

        if (isSpawning) { spawn(); }
    }
}
