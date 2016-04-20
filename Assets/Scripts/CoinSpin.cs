using UnityEngine;

public class CoinSpin : MonoBehaviour {
    private float spinForce = 250.0f;

	void Update () {
        transform.Rotate(0, Time.deltaTime * spinForce, 0);
	}
}
