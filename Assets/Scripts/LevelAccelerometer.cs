using UnityEngine;

// Script that will rotate the game object according to the input acceleration
public class LevelAccelerometer : MonoBehaviour
{
	public float maxTiltOnX;
	public float minTiltOnX;
	public float maxTiltOnY;
	public float minTiltOnY;
	
	private float initialTiltOnY;

	void Start()
	{
		initialTiltOnY = Input.acceleration.y;
	}
	
    void Update()
    {
    	AccelerometerMove(Input.acceleration);
    }

    private void AccelerometerMove (Vector3 _input)
	{
		transform.Rotate(TiltOnX(_input.x), TiltOnY(_input.y) - initialTiltOnY, 0f);
    }

    private float TiltOnX(float _x)
    {
    	if (_x < -0.1f || _x > 0.1f)
    		if (_x > maxTiltOnX)
    			return maxTiltOnX;
    		else if (_x < minTiltOnX)
    			return minTiltOnX;
    		else
    			return _x;
    	return 0f;
    }

    private float TiltOnY (float _y)
    {
    	if (_y < -0.1f || _y > 0.1f)
    		if (_y > maxTiltOnY)
    			return maxTiltOnY;
    		else if (_y < minTiltOnY)
    			return minTiltOnY;
    		else
    			return _y;
    	return 0f;
    }
}
