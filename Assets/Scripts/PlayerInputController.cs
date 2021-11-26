using UnityEngine;

/// <summary>
/// Controls all Inputs the player might be able to make.
/// </summary>
public class PlayerInputController : MonoBehaviour
{
    /// <summary>
    /// Reference to the PlayerCamera script attached to the main camera.
    /// </summary>
    public PlayerCamera playerCamera;

    /// <summary>
    /// Checks all the possible inputs and makes the calls accordingly.
    /// </summary>
    private void Update()
    {
        if (IsMouseOnScreen())
        {
            if (Input.mousePosition.y >= Screen.height * 0.95)
            {
                playerCamera.MoveForward();
            } 
            else if (Input.mousePosition.y <= Screen.height * 0.05)
            {
                playerCamera.MoveBackward();    
            }
            else if (Input.mousePosition.x >= Screen.width * 0.95)
            {
                playerCamera.MoveRight();
            }
            else if (Input.mousePosition.x <= Screen.width * 0.05)
            {
                playerCamera.MoveLeft();
            }
        }
    }

    /// <summary>
    /// Checks if the mouse cursor is inside or out of the game window.
    /// </summary>
    /// <returns>True if the cursor is inside the game window, false if the cursor is outside the game window.</returns>
    private static bool IsMouseOnScreen()
    {
        return !(Input.mousePosition.x < 0 || Input.mousePosition.x > Screen.width || Input.mousePosition.y < 0 || Input.mousePosition.y > Screen.height);
    }
}
