using UnityEngine;

public class Cpaddle : Paddle // Inherit from Paddle, so we have a reference to the Rigidbody2D attached to the computer paddle
{
    public Rigidbody2D bl; // Public reference to the ball's Rigidbody2D. Since the ball and the computer paddle are different GameObjects, this needs to be public to be assigned in the Inspector.

    private void FixedUpdate()
    {
        // Check if the ball is moving towards the computer paddle (to the right)
        if (this.bl.velocity.x > 0.0f /*|| this.bl.velocity.x < 0.0f*/) // Considering the case where the ball moves in any direction on the x-axis
        {
            // If the ball's y position is below the paddle's y position, move the paddle downwards
            if (this.bl.position.y < this.transform.position.y)
            {
                rigid.AddForce(Vector2.down * this.speed);
            }
            // If the ball's y position is above the paddle's y position, move the paddle upwards
            else if (this.bl.position.y > this.transform.position.y)
            {
                rigid.AddForce(Vector2.up * this.speed);
            }
        }
        else
        {
            // If the ball is not moving towards the computer paddle, move the paddle back to the center

            // If the paddle's y position is below the center, move the paddle upwards
            if (this.transform.position.y < 0.0f)
            {
                rigid.AddForce(Vector2.up * this.speed);
            }
            // If the paddle's y position is above the center, move the paddle downwards
            else if (this.transform.position.y > 0.0f)
            {
                rigid.AddForce(Vector2.down * this.speed);
            }
        }
    }
}
