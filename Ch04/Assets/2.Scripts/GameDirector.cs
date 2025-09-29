using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameDirector : MonoBehaviour
{
    // GameObject car;
    // GameObject flag;
    public Transform car;
    public Transform flag;
    GameObject distance;

    // Start is called before the first frame update
    void Start()
    {
        // this.car = GameObject.Find("car");
        // this.flag = GameObject.Find("flag");

        // this.car = GameObject.Find("car").transform;
        // this.flag = GameObject.Find("flag").transform;
        this.distance = GameObject.Find("distance");
    }

    // Update is called once per frame
    void Update()
    {
        float length = flag.position.x - car.position.x;
        // distance.GetComponent<TextMeshProUGUI>().text = "Distance : " + length.ToString("F2") + "m";
        TextMeshProUGUI t = distance.GetComponent<TextMeshProUGUI>();
        t.text = "거리 : " + length.ToString("F2") + " m";
    }
}
