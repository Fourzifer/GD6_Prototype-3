using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldOrbit : MonoBehaviour
{
    float timeCounter = 0;

    public float speed = 5;
    public float width = 5;
    public float height = 5;

    // Start is called before the first frame update
    void Start()
    {
        //speed = 5;
        //width = 4;
        //height = 7;
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime * speed;

        float x = Mathf.Cos(timeCounter) * width;
        float y = Mathf.Sin(timeCounter) * height;
        float z = 0;

        transform.position = new Vector3(x, y, z);
    }
}
