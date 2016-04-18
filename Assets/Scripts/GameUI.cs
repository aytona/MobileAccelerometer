using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameUI : MonoBehaviour 
{
	public GameObject[] uiObj;



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
