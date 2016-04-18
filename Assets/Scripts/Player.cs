using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour {

    public float distToGround;
    public float jumpForce;
    public float delay;

    private Rigidbody rb;
    private GameUI ui;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ui = FindObjectOfType<GameUI>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && IsGrounded())
        {
            Jump();
        }
    }

    void OnTriggerExit(Collider other)
    {
    	if (other.tag == "Finish")
    	{
    		StartCoroutine(Finished(delay));
    	}
    }

    private bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, distToGround + 0.1f);
    }

    private void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce);
    }

    private IEnumerator Finished(float _delay)
    {
    	ui.StartGoal();
    	return new WaitForSeconds(_delay);
    	ui.ToMain();
    }
}
