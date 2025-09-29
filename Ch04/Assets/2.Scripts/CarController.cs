using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0f;
    public float decreaseRatio = 0.98f;
    public float speedRatio = 1000;
    Vector2 startPos;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;//속도맞추기 프레임
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("deltaTime : " + Time.deltaTime);//프레임 바꾸든 안 바꾸든 일정하게 됨
        if (Input.GetMouseButtonDown(0))
        {
            //this.speed = 0.2f;
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - startPos.x;
            this.speed = swipeLength / speedRatio;
            GetComponent<AudioSource>().Play();
        }

        transform.Translate(this.speed, 0, 0);
        this.speed *= decreaseRatio;
        if (this.speed < 0.01f)
        {
            this.speed = 0f;
        }
    }
}
