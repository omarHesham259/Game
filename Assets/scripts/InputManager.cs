using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class InputManager : MonoBehaviour
{

  private PlayerInput PlayerInput;
  private PlayerInput.OnFootActions onfoot ;

  private PlayerMotor motor;
    // Start is called before the first frame update
    void Awake()
    {
          PlayerInput = new PlayerInput();
          onfoot = PlayerInput.OnFoot;
      motor =GetComponent<PlayerMotor>();

    }

    // Update is called once per frame
    void FixedUpdate()
    { 
        // tell the playermotor  to move using the value from our movment action.
        motor.ProcessMove(onfoot.Movment.ReadValue<Vector2>());
    }

    private void OnEnable(){
        onfoot.Enable();

    }

    private void OnDisable(){
        onfoot.Disable();
        
    }
}
