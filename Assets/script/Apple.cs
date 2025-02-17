using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public static float bottomY = -20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    public GameObject treefallboom;
    // Update is called once per frame
    void Update()
    {
        if ( transform.position.y < bottomY ) {
            Destroy( this.gameObject );
            

        }
        Vector3 pos = treefallboom.transform.position;
        if(pos.y < bottomY){
            Destroy(treefallboom);
        }


    }
}
