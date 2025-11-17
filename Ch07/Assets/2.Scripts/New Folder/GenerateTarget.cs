using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateTarget : MonoBehaviour
{
    public GameObject target;

    Transform[] destinations;

    // Start is called before the first frame update
    void Start()
    {
        destinations = GetComponentsInChildren<Transform>();
    }

    public void Generater()
    {
        int index;
        Vector3 pos;

        index = Random.Range(1, destinations.Length);
        pos = destinations[index].position;

        GameObject go = Instantiate(target, pos, Quaternion.identity);
        go.transform.SetParent(destinations[index]);
    }
}
