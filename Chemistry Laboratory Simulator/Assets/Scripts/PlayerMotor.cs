using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 PlayerVelocity;
    public float speed = 5f;
    private bool isGrounded;
    public float gravity = -9.8f;
    public float JumpHeight = 3f;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = controller.isGrounded;
    }
    public void ProcessMove(Vector2 input){
        Vector3 MoveDirection = Vector3.zero;
        MoveDirection.x = input.x;
        MoveDirection.z = input.y;
        controller.Move(transform.TransformDirection(MoveDirection) * speed * Time.deltaTime);
        PlayerVelocity.y += gravity * Time.deltaTime;
        if(isGrounded && PlayerVelocity.y < 0)
            PlayerVelocity.y = -2f;
        controller.Move(PlayerVelocity * Time.deltaTime);
        }
    public void Jump(){
        if (isGrounded){
            PlayerVelocity.y = Mathf.Sqrt(JumpHeight * -3.0f * gravity);
        }
    }
}
