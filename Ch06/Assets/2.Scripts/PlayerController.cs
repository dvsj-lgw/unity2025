using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    Animator animator;
    public float jumpForce = 400f;
    public float walkForce = 20f;
    public float maxWalkSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && rb.velocity.y == 0)
        {
            rb.AddForce(transform.up * jumpForce);
            animator.SetTrigger("Jump Trigger");
        }

        int key = 0;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;

        float speedX = Mathf.Abs(rb.velocity.x);
        if (speedX < maxWalkSpeed)
        {
            rb.AddForce(transform.right * key * walkForce);
        }

        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        if (rb.velocity.y == 0)
        {
            animator.speed = speedX / 2;
        }
        else
        {
            animator.speed = 1;
        }
        

        if (transform.position.y < -10)
        {
            string sceneName = SceneManager.GetActiveScene().name; // 현재 내 씬
            SceneManager.LoadScene(sceneName);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Goal!");
        SceneManager.LoadScene("Clear Scene");
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "cloud")
        {
            transform.SetParent(collision.gameObject.transform);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "cloud")
        {
            transform.parent = null;
        }
        
    }
}
