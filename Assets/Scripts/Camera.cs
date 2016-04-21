using UnityEngine;
using System.Collections;

// Left-Right = Y
// Up-Down = X
public class Camera : MonoBehaviour {

    public Transform _target;

    // Position offsets
    private float _yOffsetP = 5f;
    private float _zOffsetP = -5f;

    void Update()
    {
        // Position
        Vector3 _pos = _target.transform.position;
        _pos.y += _yOffsetP;
        _pos.z += _zOffsetP;
        transform.position = _pos;
    }
}
