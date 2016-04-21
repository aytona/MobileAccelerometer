using UnityEngine;
using System.Collections;

public class PivotHandler : MonoBehaviour {

    public void ReceiveInput(Vector2 swipeVector, float swipeDistance)
    {
        if (swipeVector.x > 0.1f || swipeVector.x <-0.1f)
        {
            transform.Rotate(swipeVector.x, 0f, 0f);
        }
    }
}
