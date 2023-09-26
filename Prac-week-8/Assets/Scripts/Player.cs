using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    private PlayerActions actions;
    private InputAction movementAction;
    // Start is called before the first frame update
    void Awake()
    {
        actions = new PlayerActions();
        movementAction = actions.PlayerMovement.movement;
    }

    void OnEnable()
    {
        movementAction.Enable();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float accelerationForward = movementAction.ReadValue<Vector3>().z;
        transform.Translate(Vector3.forward * speed * accelerationForward * Time.deltaTime, Space.Self);
        float accelerationRight = movementAction.ReadValue<Vector3>().x;
        transform.Translate(Vector3.right * speed * accelerationRight * Time.deltaTime, Space.Self);
    
    }
    void OnDisable()
    {
        movementAction.Disable();
    }
}
