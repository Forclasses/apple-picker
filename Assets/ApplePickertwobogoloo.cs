using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePickertwobogoloo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    //[Header("Inscribed")]
    public GameObject basketPrefeb;
    public int numBaskets = 4;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;

    void Start()
    {
        for (int i=0 ; i < numBaskets ; i++) {
            GameObject tBasketG0 = Instantiate<GameObject>( basketPrefeb );
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + ( basketSpacingY * i);
            tBasketG0.transform.position = pos;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
