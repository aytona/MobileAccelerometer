using UnityEngine;

// Script that will rotate the game object according to the input acceleration
public class LevelAccelerometer : MonoBehaviour
{
    private Quaternion _rot;

    void Start()
    {
        _rot = transform.rotation;
    }

    void Update()
    {
        //AccelerationMovement();

        //transform.Rotate(Input.acceleration);
    }

    #region TiltMovement

    //private Vector3 AccelerationInput()
    //{
    //    Vector3 acceleration = Input.acceleration;
    //    if (acceleration.magnitude < -0.1f || acceleration.magnitude > 0.1f)
    //    {
    //        return acceleration;
    //    }
    //    return Vector3.zero;
    //}

    private Vector3 AccelerationInput()
    {
        return Input.acceleration;
    }

    private void AccelerationMovement()
    {
        //transform.rotation = Quaternion.Euler(AccelerationInput());

        _rot.x += AccelerationInput().x;
        _rot.y += AccelerationInput().y;
        transform.rotation = _rot;
    }

    #endregion TiltMovement
}
