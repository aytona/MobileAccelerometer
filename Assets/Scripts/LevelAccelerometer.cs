using UnityEngine;

// Script that will rotate the game object according to the input acceleration
public class LevelAccelerometer : MonoBehaviour
{
    void Update()
    {
    	AccelerometerMove(Input.acceleration);
    }

    private void AccelerometerMove (Vector3 _input)
	{
		transform.Rotate(TiltOnX(_input.x), TiltOnY(_input.y), 0f);
    }

    private float TiltOnX(float _x)
    {
    	if (_x < -0.1f || _x > 0.1f)
    		return _x;
    	return 0f;
    }

    private float TiltOnY (float _y)
    {
    	if (_y < -0.1f || _y > 0.1f)
    		return _y;
    	return 0f;
    }
}
