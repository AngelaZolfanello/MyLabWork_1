using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public GameObject helloText;
    int speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        print("Hello World!");
        helloText.GetComponent<TextMeshPro>().text = "Hello, Hell!";
    }

    // Update is called once per frame
    void Update()
    {
        //print("See you in Hell!");
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
    }
}
