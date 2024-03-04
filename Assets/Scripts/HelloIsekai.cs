using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HelloIsekai : MonoBehaviour
{
    int speed = 10;
    void Start()
    {
       
    }
    void Update()
    {
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
    }
}
