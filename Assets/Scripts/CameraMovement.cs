using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float moveSpeed;
    // Update is called once per frame
    void Update()
    {
        if (Input.mousePosition.x < 10)
        {
            // Scroll left
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
        if (Input.mousePosition.x > Screen.width - 10)
        {
            // Scroll right
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
        if (Input.mousePosition.y < 10)
        {
            //Scroll down
            transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        }
        if (Input.mousePosition.y > Screen.height - 10)
        {
            //Scroll up
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        }

    }
}
