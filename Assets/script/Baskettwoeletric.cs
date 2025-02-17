using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Baskettwoeletric : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos2D = Input.mousePosition;

        mousePos2D.z = -Camera.main.transform.position.z;

        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint( mousePos2D );

        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
        //This dose not work with muitable baskets it combines them into one, so I am using a and s and arrow keys to gte the stuff I need
    }
}
