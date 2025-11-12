using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movingtf : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotateSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * rotateSpeed * Time.deltaTime;
        float zSpeed = zInput * moveSpeed * Time.deltaTime;

        transform.Translate(0, 0, zSpeed);
        transform.Rotate(0, xSpeed, 0);
    }
}
