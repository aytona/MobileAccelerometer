using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour {

    public float distToGround;
    public float jumpForce;
    public float delay;

    private Rigidbody rb;
    private GameUI ui;
    private int score;
    private Data _data;

    void Start()
    {
        _data = FindObjectOfType<Data>();
        rb = GetComponent<Rigidbody>();
        ui = FindObjectOfType<GameUI>();
        score = 0;
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
        if (other.tag == "Level")
        {
            ui.GameOver();
            _data.SetHighscoreArray(getScore());
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
        _data.SetHighscoreArray(getScore());
    	yield return new WaitForSeconds(_delay);
    	ui.ToMain();
    }

    private void increaseScore(int amount)
    {
        score += amount;
    }

    public int getScore()
    {
        return score;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            increaseScore(100);
            Destroy(other.gameObject);
        }
    }
}
