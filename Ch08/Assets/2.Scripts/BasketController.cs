using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    public AudioClip appleSE;
    public AudioClip bombSE;
    GameObject GM;
    GameDeractor gameDirector;

    AudioSource aud;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        aud = GetComponent<AudioSource>();
        // gameDirector = GameObject.Find("GameDirector").GetComponent<GameDirector>();
        GM = GameObject.Find("GameDirector");
        gameDirector = GM.GetComponent<GameDeractor>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                float x = Mathf.RoundToInt(hit.point.x);
                float z = Mathf.RoundToInt(hit.point.z);
                transform.position = new Vector3(x,0,z);

            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("잡았다.");
        if (other.gameObject.tag.Equals("apple"))
        {
            Debug.Log("사과");
            aud.PlayOneShot(appleSE);
            gameDirector.GetApple();
        }
        else if (other.gameObject.tag.Equals("bomb"))
        {
            Debug.Log("폭탄");
            aud.PlayOneShot(bombSE);
            gameDirector.GetBomb();
        }

        Destroy(other.gameObject);
    }
}
