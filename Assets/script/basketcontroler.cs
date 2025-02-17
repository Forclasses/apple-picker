using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;
using UnityEngine.InputSystem;

public class basketcontroler : MonoBehaviour
{
    private Inputs inputs;
    public ScoreCounterone scoreCounter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       inputs = new Inputs();
       inputs.Enable();
       inputs.Player.Move.performed += MoveBasket; 

       GameObject scoreGO= GameObject.Find ("ScoreCounter");
       scoreCounter = scoreGO.GetComponent<ScoreCounterone>();
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
        //print(collisionInfo.gameObject.name);
        GameObject collidedWith = collisionInfo.gameObject;
        if( collidedWith.CompareTag("Apple")){
            Destroy(collisionInfo.gameObject);
            scoreCounter.score += 100;
            
        } else if (collidedWith.CompareTag("Branch")){
            Destroy(collisionInfo.gameObject);
            scoreCounter.score = 0;
            print("Game Over");
            Application.Quit();
        }
        Destroy(collisionInfo.gameObject);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
