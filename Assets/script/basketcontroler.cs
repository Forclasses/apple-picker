using UnityEngine;

public class basketcontroler : MonoBehaviour
{
    private Inputs inputs;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       inputs = new Inputs();
       inputs.Enable();
       inputs.Player.Move.performed += MoveBasket; 
    }

    private void MoveBasket(InputAction.CallbackContext context){

        //I feel sick
        //see 1/30 meeting
    }

    void OnCollisionEnter(Collision collisionInfo){
        print(collisionInfo.gameObject.name);
        
        if(collisionInfo.gameObject.CompareTag("Apple")){
            print("You won");
        }
        Destroy(collisionInfo.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
