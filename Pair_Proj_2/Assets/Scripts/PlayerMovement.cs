using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 3;
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

    public void OnMovement(InputAction.CallbackContext context)
    {
        Vector2 recVector2 = context.ReadValue<Vector2>();
        //Debug.Log(recVector2);
        movementVector = new Vector3(recVector2.x, 0, recVector2.y);

    }


   
}