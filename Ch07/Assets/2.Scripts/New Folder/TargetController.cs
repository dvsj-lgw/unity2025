using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    GenerateTarget gt;

    // Start is called before the first frame update
    void Start()
    {
        gt = GameObject.FindObjectOfType<GenerateTarget>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("bamsongi"))
        {
            gt.Generate();
            //Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
