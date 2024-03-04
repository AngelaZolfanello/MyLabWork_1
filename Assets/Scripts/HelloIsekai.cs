using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HelloIsekai : MonoBehaviour
{
    public GameObject helloText;
    int speed = 10;
    void Start()
    {
        print("Hello World!");
        helloText.GetComponent<TextMeshPro>().text = "Hello, Hell!";
    }
    void Update()
    {
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
    }
}
