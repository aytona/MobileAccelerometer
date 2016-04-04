using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class TitleUI : MonoBehaviour
{
    public GameObject leaderboardObj;
    public GameObject menuObj;

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
