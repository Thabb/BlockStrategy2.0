using UnityEngine;

/// <summary>
/// Responsible for the movement of the camera.
/// </summary>
public class PlayerCamera : MonoBehaviour
{
    /// <summary>
    /// Moves the camera forward, towards the upper end of the screen.
    /// </summary>
    public void MoveForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
    }

    /// <summary>
    /// Moves the camera backward, towards the lower end of the screen.
    /// </summary>
    public void MoveBackward()
    {
        transform.Translate(Vector3.back * Time.deltaTime);
    }

    /// <summary>
    /// Moves the camera right, towards the right end of the screen.
    /// </summary>
    public void MoveRight()
    {
        transform.Translate(Vector3.right * Time.deltaTime);
    }

    /// <summary>
    /// Moves the camera left, towards the left end of the screen.
    /// </summary>
    public void MoveLeft()
    {
        transform.Translate(Vector3.left * Time.deltaTime);
    }

    /// <summary>
    /// Moves the camera down, towards the plane.
    /// </summary>
    public void ZoomIn()
    {
        transform.Translate(Vector3.down * Time.deltaTime);
    }

    /// <summary>
    /// Moves the camera up, away from the plane.
    /// </summary>
    public void ZoomOut()
    {
        transform.Translate(Vector3.up * Time.deltaTime);
    }
}
