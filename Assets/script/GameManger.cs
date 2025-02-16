using UnityEngine;

namespace ApplePicker.Apple
{
public class GameManger : MonoBehaviour
{
    public GameObject apple;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       // new AppleController(apple);
       // InvokeRepeating(nameof(AppleFall), 1f,1f);
       //AppleFall(); 
    }

    //void AppleFall(){
    /// <summary>
    ///    Instantiate(apple, new Vector3(Random.Range(-8f,8f),5,0), Quaternion.identity);
    /// </summary>
    //}

    // Update is called once per frame
    void Update()
    {
        
    }
}
}