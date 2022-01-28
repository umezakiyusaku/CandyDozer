using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 0.1f);
        transform.Rotate(0, 8f, 0);
        transform.position = new Vector3(Mathf.Cos(Time.time*7), Mathf.Sin(Time.time),Time.time*5);
    }
}
