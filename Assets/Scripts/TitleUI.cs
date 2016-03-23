using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class TitleUI : MonoBehaviour {

	public void StartGame() {
		SceneManager.LoadScene(1);
	}

	public void QuitGame() {
		Application.Quit();
	}
}
