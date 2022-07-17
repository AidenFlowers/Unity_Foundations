using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    Vector3 movementVector;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += movementVector * Time.deltaTime * speed;
        
    }

    void OnMovement(InputAction.CallbackContext context)
    {
        Vector2 recVector2 = context.ReadValue<Vector2>();
        movementVector = new Vector3(recVector2.x, 0, recVector2.y);
    }

   
}
