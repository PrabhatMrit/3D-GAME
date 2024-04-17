using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Speed of rotation
    public float rotationSpeed = 100f;

    void Update()
    {
        // Check for input to turn left continuously while 'Z' key is pressed
        if (Input.GetKey(KeyCode.Z))
        {
            TurnLeft();
        }

        // Check for input to turn right continuously while 'C' key is pressed
        if (Input.GetKey(KeyCode.C))
        {
            TurnRight();
        }
    }

    void TurnLeft()
    {
        // Rotate the player to the left
        transform.Rotate(Vector3.up * -rotationSpeed * Time.deltaTime);
    }

    void TurnRight()
    {
        // Rotate the player to the right
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
