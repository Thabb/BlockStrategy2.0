using UnityEngine;

/// <summary>
/// Responsible for the movement of the camera.
/// </summary>
public class PlayerCamera : MonoBehaviour
{
    /// <summary>
    /// Speed with which the camera will move to the sides.
    /// </summary>
    private const float ScrollSpeed = 5;
    /// <summary>
    /// Speed with which the camera zooms in and out.
    /// </summary>
    private const float ZoomSpeed = 1;
    
    /// <summary>
    /// Moves the camera forward, towards the upper end of the screen.
    /// </summary>
    public void MoveForward()
    {
        transform.Translate(new Vector3(0,0, ScrollSpeed) * Time.deltaTime);
    }

    /// <summary>
    /// Moves the camera backward, towards the lower end of the screen.
    /// </summary>
    public void MoveBackward()
    {
        transform.Translate(new Vector3(0, 0, -ScrollSpeed) * Time.deltaTime);
    }

    /// <summary>
    /// Moves the camera right, towards the right end of the screen.
    /// </summary>
    public void MoveRight()
    {
        transform.Translate(new Vector3(ScrollSpeed,0,0) *  Time.deltaTime);
    }

    /// <summary>
    /// Moves the camera left, towards the left end of the screen.
    /// </summary>
    public void MoveLeft()
    {
        transform.Translate(new Vector3(-ScrollSpeed,0,0) * Time.deltaTime);
    }

    /// <summary>
    /// Moves the camera down, towards the plane.
    /// </summary>
    public void ZoomIn()
    {
        transform.Translate(new Vector3(0,-ZoomSpeed,0) * Time.deltaTime);
    }

    /// <summary>
    /// Moves the camera up, away from the plane.
    /// </summary>
    public void ZoomOut()
    {
        transform.Translate(new Vector3(0,ZoomSpeed,0) * Time.deltaTime);
    }
}
