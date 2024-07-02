using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rigidbodyy; // Reference to the Rigidbody2D component for physics-based movement
    public float spd = 200f; // Speed factor to control the initial force applied to the ball

    private void Awake()
    {
        // Find and assign the Rigidbody2D component attached to this GameObject
        rigidbodyy = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        // Reset the ball's position and velocity
        resPos();
        // Apply an initial force to the ball
        StartingForce();
    }

    public void StartingForce()
    {
        // Determine the x direction randomly (either -1.0 or 1.0)
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        // Determine the y direction randomly within specified ranges to vary the angle
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);

        // Create a direction vector based on the random x and y values
        Vector2 direct = new Vector2(x, y);
        // Apply the initial force to the ball's Rigidbody2D component, scaled by the speed factor
        rigidbodyy.AddForce(direct * this.spd);
    }

    public void AddForce(Vector2 force)
    {
        // Apply an additional force to the ball's Rigidbody2D component
        rigidbodyy.AddForce(force);
    }

    public void resPos()
    {
        // Reset the ball's position to the center (0,0,0)
        rigidbodyy.position = Vector3.zero;
        // Reset the ball's velocity to zero to stop its movement
        rigidbodyy.velocity = Vector3.zero;
    }
}
