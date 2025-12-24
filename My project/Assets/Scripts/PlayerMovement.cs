using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private float gravityValue = -1f;
    
    public CharacterController player;
    InputAction axisInput;

    public Vector3 moveValue;
    public Vector3 playerVelocity;

    public float speed = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        axisInput = InputSystem.actions.FindAction("Move");
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // Read Input
        Vector2 input = axisInput.ReadValue<Vector2>();
        moveValue = new Vector3 (input.x, 0f, 0f);

        if (playerVelocity.y >= -25f)
        {
            playerVelocity.y += gravityValue * Time.deltaTime;
        }

        //Move
        moveValue = Vector3.ClampMagnitude(moveValue, 1f) * speed + Vector3.up * playerVelocity.y;
        player.Move(moveValue * Time.deltaTime);
    }
}
