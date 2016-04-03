using UnityEngine;

// Script that will rotate the game object according to the input acceleration
public class LevelAccelerometer : MonoBehaviour
{
    void Update()
    {
        AccelerationMovement();
    }

    #region TiltMovement

    private Vector3 AccelerationInput()
    {
        Vector3 acceleration = Input.acceleration;
        if (acceleration.magnitude < -0.1f || acceleration.magnitude > 0.1f)
        {
            return acceleration;
        }
        return Vector3.zero;
    }

    private void AccelerationMovement()
    {
        transform.rotation = Quaternion.Euler(AccelerationInput());
    }

    #endregion TiltMovement
}
