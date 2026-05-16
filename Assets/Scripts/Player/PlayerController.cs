using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Vector2 moveInput;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        // Move the player based on input
        rb.linearVelocity = moveInput * moveSpeed;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        // Read the movement input
        moveInput = context.ReadValue<Vector2>();
    }
}
