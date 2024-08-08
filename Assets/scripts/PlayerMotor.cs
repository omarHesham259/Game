using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{

  private CharacterController controller;
  private Vector3 PlayerVelocity;

  public float Speed  = 5;
    int y;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  //  recive the inputs for our InputManager.cs and apply them to our Charchter contoller.
    public void ProcessMove(Vector2 Input)
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = Input.x;
        moveDirection.z = Input.y;
        controller.Move(transform.TransformDirection(moveDirection) * Speed* Time.deltaTime);
    }
    // Hello World!!
    // branch b 
}
