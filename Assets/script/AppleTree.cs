using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [Header("Inscribed")]

    public GameObject appleprefab;
    public GameObject branchprefab;
    
    public float speed = 1f;

    public float leftAndRightEdge = 10f;

    public float changeDirChance = 0.02f;

    public float appleDropDelay = 1f;
    public float appletik = 0.99f;
    void Start()
    {
        Invoke ( "DropApple", 2f );
        
    }
    

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if (pos.x < -leftAndRightEdge ) {
            speed = Mathf.Abs( speed );
        } else if (pos.x > leftAndRightEdge){
            speed = -Mathf.Abs( speed );
        //} else if (Random.value < changeDirChance ){
        //    speed *= -1;
        }
    }

    void FixedUpdate()
    {
        if ( Random.value < changeDirChance) {
            speed *= -1;
        }
    }

    void DropApple(){
        GameObject apple = Instantiate<GameObject>( appleprefab );
        GameObject branch = Instantiate<GameObject>( branchprefab);
        appletik = 0.99f;
        //branchtik= 0.002f;
        if(Random.value < appletik){
        apple.transform.position = transform.position;
        } else {
            branch.transform.position = transform.position;
        }
        Invoke ( "DropApple", appleDropDelay );
    }

}

