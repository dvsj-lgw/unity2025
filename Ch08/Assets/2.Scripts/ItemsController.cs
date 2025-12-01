using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsController : MonoBehaviour
{
    public float dropSpeed = -3f;
 
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,dropSpeed * Time.deltaTime, 0);
        if(transform.position.y < -1.0f)
        {
            Destroy(gameObject);
        }
    }
}
