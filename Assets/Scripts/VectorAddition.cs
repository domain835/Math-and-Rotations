using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorAddition : MonoBehaviour
{
    public Transform Object1;
    public Transform Object2;

    // Update is called once per frame
    void Update()
    {
        transform.position = Object1.position + Object2.position;
    }
}
