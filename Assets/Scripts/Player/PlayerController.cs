using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Scripting.APIUpdating;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D body;
    private Maininput controls;
    // Start is called before the first frame update
    void Awake()
    {
        controls = new Maininput();
        body = GetComponent<Rigidbody2D>();
    }
    void OnEnable()
    {
        controls.Enable();
    }
    
    void OnDisable()
    {
        controls.Disable();
    }
    void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        Vector2 moveInput = controls.Player.Move.ReadValue<Vector2>();
        Vector2 movement = moveInput * 5 * Time.fixedDeltaTime;
        body.MovePosition(body.position + movement);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
