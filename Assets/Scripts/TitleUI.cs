using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class TitleUI : MonoBehaviour
{
    public GameObject leaderboardObj;
    public GameObject menuObj;
    public Text[] leaderboardScores;

    private Data data;
    private int[] dataScores;

    #region Monodev

    void Start()
    {
    	data = FindObjectOfType<Data>();
    	dataScores = data.GetHighscore();

    	for (int i = 0; i < leaderboardScores.Length; i++)
    	{
    		leaderboardScores[i].text = dataScores[i].ToString();
    	}
    }

    #endregion Monodev

    #region ButtonFunctions

    public void StartGame()
    {
		SceneManager.LoadScene(1);
	}

	public void QuitGame()
    {
		Application.Quit();
	}

    public void Leaderboard()
    {
        leaderboardObj.SetActive(true);
        menuObj.SetActive(false);
    }

    public void Menu()
    {
        leaderboardObj.SetActive(false);
        menuObj.SetActive(true);
    }

    #endregion ButtonFunctions
}
