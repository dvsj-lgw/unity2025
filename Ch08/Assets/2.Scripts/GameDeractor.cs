using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameDeractor : MonoBehaviour
{
    
    public TextMeshProUGUI pointText;
    int point = 0;

    // Start is called before the first frame update
    void Start()
    {
        pointText.text = "Point : 0";
    }

    // Update is called once per frame
    void Update()
    {
        pointText.text = "Point : " + point;
    }

    public void GetApple()
    {
        point += 10;
    }

    public void GetBomb()
    {
        point /= 2;
    }
}
