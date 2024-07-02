using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D rigid; // Reference to the Rigidbody2D component. Protected means this variable is accessible within this class and by derived classes (e.g., Ppaddle, Cpaddle).
    public float speed = 12f; // Speed at which the paddle can move.

    private void Awake()
    {
        // Find and assign the Rigidbody2D component attached to the same GameObject that this script is attached to.
        rigid = GetComponent<Rigidbody2D>();
    }

    public void resetPosition()
    {
        // Reset the paddle's position to keep the x-coordinate the same but set the y-coordinate to 0.
        rigid.position = new Vector2(rigid.position.x, 0.0f);

        // Reset the paddle's velocity to zero, stopping any movement.
        rigid.velocity = Vector2.zero;
    }
}
