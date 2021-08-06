using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Linq;
using static UnityEngine.InputSystem.InputAction;

public class PlayerInputHandler : MonoBehaviour
{
    private PlayerConfiguration playerConfig;
    private Car car;
    [SerializeField]
    private MeshRenderer playerMesh = null;

    private PlayerControls controls;
    // Start is caled before the first frame update
    void Awake()
    {
        car = GetComponent<Car>();
        controls = new PlayerControls();
        
    }

    public void InitializePlayer(PlayerConfiguration pc) {
        playerConfig = pc;
        playerMesh.material = pc.PlayerMaterial;
        playerConfig.Input.onActionTriggered += Input_onActionTriggered;
    }

    private void Input_onActionTriggered(CallbackContext obj) {
        if(obj.action.name == controls.PlayerMovement.Throttle.name) {
            OnThrottle(obj);
        }
        if(obj.action.name == controls.PlayerMovement.Steer.name) {
            OnSteer(obj);
        }
        if(obj.action.name == controls.PlayerMovement.Brake.name) {
            OnBrake(obj);
        }
        if(obj.action.name == controls.PlayerMovement.Reverse.name) {
            OnReverse(obj);
        }
        if(obj.action.name == controls.PlayerMovement.Reset.name) {
            OnReset(obj);
        }
        if(obj.action.name == controls.PlayerMovement.CameraMovement.name) {
            OnCamera(obj);
        }
    }

    public void OnSteer(CallbackContext context) {
        if(car != null) {
            car.Steer = context.ReadValue<Vector2>().x;
        }
    }
    private void OnThrottle(CallbackContext context) {
        if (car != null) {
            if (context.performed) {
                car.Throttle = context.ReadValue<float>();
            }else if (context.canceled) {
                car.Throttle = 0;
            }           
        }
    }
    private void OnBrake(CallbackContext context) {
        if (car != null) {
            if (context.performed) {
                car.Brake = 1;
            } else if (context.canceled) {
                car.Brake = 0;
            }
        }
    }
    private void OnReverse(CallbackContext context) {
        if (car != null) {
            if (context.performed) {
                car.MinusThrottle = context.ReadValue<float>();
            } else if (context.canceled) {
                car.MinusThrottle = context.ReadValue<float>();
            }
        }
    }
    private void OnReset(CallbackContext context) {
        if(car != null) {
            if (context.performed) {
            } else if (context.canceled) {
                car.ResetCar();
            }
        }
    }
    private void OnCamera(CallbackContext context) {
        var moveVector = context.ReadValue<Vector2>();
        if (car != null) {
            car.MoveCamera(moveVector);
        }
    }
}
