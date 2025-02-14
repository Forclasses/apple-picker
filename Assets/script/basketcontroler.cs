using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;
using UnityEngine.InputSystem;

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

        
        Vector2 moveDirection = context.ReadValue<Vector2>();
        //print(moveDirection);
        transform.position += new Vector3(moveDirection.x, 0);
    }
    void OnDestroy()
    {
        inputs.Player.Move.performed -= MoveBasket;
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
