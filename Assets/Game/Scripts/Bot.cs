using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : Character
{
    // Start is called before the first frame update
    void Start()
    {
        n = Random.RandomRange(0, 3);
        Renderer renderer = GetComponent<Renderer>();
        if (n == 0)
        {
            renderer.material.color = Color.green;
        }
        if (n == 1)
        {
            renderer.material.color = Color.blue;
        }
        if (n == 2)
        {
            renderer.material.color = Color.red;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(EatBrick.Count>5)
        {

        }
    }
}
