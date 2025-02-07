using UnityEngine;
namespace ApplePicker.Apple
{
public class AppleController : MonoBehaviour
{
    private GameObject apple;

    public AppleController(GameObject apple){
        this.apple = apple;
        AppleFall();
    }

     void AppleFall(){
        Instantiate(apple, new Vector3(Random.Range(-8f,8f),5,0), Quaternion.identity);
    }

}
}