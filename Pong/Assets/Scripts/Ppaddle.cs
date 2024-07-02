using UnityEngine;

public class Ppaddle : Paddle
{
    private Vector2 direct; // Variable to store the direction of the paddle's movement

    private void Update()
    {
        // Check if the Up Arrow key is being held down
        if (Input.GetKey(KeyCode.UpArrow))
        {
            direct = Vector2.up; // Set the direction to move upwards
        }
        // Check if the Down Arrow key is being held down
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            direct = Vector2.down; // Set the direction to move downwards
        }
        else
        {
            direct = Vector2.zero; // No movement if no key is pressed
        }
    }

    private void FixedUpdate()
    {
        // Check if the paddle is moving (direction vector is not zero)
        if (direct.sqrMagnitude != 0)
        {
            rigid.AddForce(direct * this.speed); // Apply force to move the paddle in the specified direction
        }
    }
}
