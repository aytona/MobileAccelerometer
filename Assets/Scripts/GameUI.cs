using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameUI : MonoBehaviour 
{
	public GameObject[] uiObj;
    public Text timerText;
    public Text scoreText;

    private float timeLeft;
    private bool isGameOver;
    private Player _player;

    void Start()
    {
        timeLeft = 300.0f;
        isGameOver = false;
        _player = FindObjectOfType<Player>();
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        timerText.text = "Time Left: " + (int)timeLeft;
        scoreText.text = _player.getScore().ToString();
        if (timeLeft <= 0 && !isGameOver)
        {
            GameOver();
        }
    }

    #region ButtonFunctions
    public void PauseGame()
	{
		ResetUIObj();
		EnableUIObj("Pause");
		Time.timeScale = 0;
	}

	public void ResumeGame()
	{
		ResetUIObj();
		EnableUIObj("Main");
		Time.timeScale = 1;
	}
	#endregion ButtonFunctions

	#region EventFunctions
	public void StartGoal()
	{
		ResetUIObj();
		EnableUIObj("Finish");
		Time.timeScale = 0;
	}

	public void ToMain()
	{
		SceneManager.LoadScene(0);
	}

    public void GameOver()
    {
        isGameOver = true;
        Time.timeScale = 0;
        ResetUIObj();
        EnableUIObj("GameOver");
    }

    #endregion EventFunctions

    #region PrivateFunctions
    private void ResetUIObj()
	{
		foreach(GameObject i in uiObj)
		{
			i.SetActive(false);
		}
	}

	private void EnableUIObj(string name)
	{
		foreach(GameObject i in uiObj)
		{
			if (i.name == name)
			{
				i.SetActive(true);
			}
		}
	}
	#endregion PrivateFunctions
}
