using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteContoller : MonoBehaviour
{
    float rotSpeed = 0f;
    public float startSpeed = 20f;
    public float dRatio = 0.995f;
    public float minSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 1 오른쪽
        {
            this.rotSpeed = startSpeed;
        }

        transform.Rotate(0, 0, -rotSpeed);
        this.rotSpeed *= dRatio;

        if (this.rotSpeed < this.minSpeed)
        {
            this.rotSpeed = 0f;    
        }
        
    }
}
