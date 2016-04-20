using UnityEngine;

public class Data : Singleton<Data> {
    #region Public

    public void SetHighscoreArray(float score) {
        int[] savedHighscore = new int[3];
        int tempScore;
        int paramScore = (int)score;
        for (int i = 0; i < savedHighscore.Length; i++) {
            if (savedHighscore[i] <= paramScore) {
                tempScore = savedHighscore[i];
                savedHighscore[i] = paramScore;
                paramScore = tempScore;
            }
        }

        PlayerPrefsX.SetIntArray("Highscores", savedHighscore);
    }

    public void SetScore(int newScore) {
        currentScore = newScore;
        PlayerPrefs.SetInt("CurrentScore", currentScore);
    }

    public int GetScore() {
        return currentScore;
    }

    public int[] GetHighscore() {
        int[] savedHighscores = PlayerPrefsX.GetIntArray("Highscores", 0, 3);
        return savedHighscores;
    }

    #endregion Public

    #region Private

    private int currentScore = 0;
    private Data() { }

    #endregion Private
}