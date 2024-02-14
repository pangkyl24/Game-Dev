using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefab : MonoBehaviour
{
    public GameObject myPrefab;
    private bool isSpawning;

    void Start()
    {
        isSpawning = false;
    }
    
    public void spawn()
    {
        Debug.Log("clicked");
        if (isSpawning == false)
        {
            isSpawning = true;
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isSpawning)
        {
            Instantiate(myPrefab, Input.mousePosition, Quaternion.identity);
            isSpawning = false;
        }
    }
}
