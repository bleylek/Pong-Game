using UnityEngine;

public class bouncy : MonoBehaviour
{
    public float bStr; // The strength of the bounce force

    // This method is called when the object collides with another object
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Get the Ball component from the object that collided with this surface
        // This checks if the object that collided has the Ball component
        Ball ball = collision.gameObject.GetComponent<Ball>();

        // If the Ball component is found, it means the object that collided is a ball
        if (ball != null)
        {
            // Get the normal vector of the collision contact point
            // The normal vector represents the direction of the surface at the collision point
            Vector2 normal = collision.GetContact(0).normal;

            // Apply a force to the ball in the opposite direction of the normal vector
            // The force is scaled by the bounce strength (bStr)
            ball.AddForce(-normal * this.bStr);
        }
    }
}
