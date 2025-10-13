using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    public float dropSpeed = 1f;
    public float arrowRadius = 0.3f;
    public float playerRadius = 0.7f;

    Transform playerTransform;

    private void Start()
    {
        playerRadius = GameObject.Find("player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -dropSpeed, 0);

        if (transform.position.y < -7f)
        {
            Destroy(gameObject);//자기 자신
        }
        CheckCollision();
    }
    void CheckCollision()
    {
        Vector2 arrowPosition = transform.position;
        Vector2 playerPosition = playerTransform.position;
        float Distance = (arrowPosition - playerPosition).magnitude;

        // 충돌 발생
        if(Distance < arrowRadius + playerRadius)
        {
            Destroy(gameObject);
        }
    }
}
