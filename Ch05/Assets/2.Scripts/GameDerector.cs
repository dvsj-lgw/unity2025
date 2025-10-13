using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDerector : MonoBehaviour
{
    public GameObject hpGage;

    public void DecreaseHP()
    {
        this.hpGage.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
