using UnityEngine;
using System.Collections;

public class CoinSpin : MonoBehaviour {
    private float spinForce = 250.0f;

	// Update is called once per frame
	void Update () {
        transform.Rotate(0, Time.deltaTime * spinForce, 0);
	}
}
