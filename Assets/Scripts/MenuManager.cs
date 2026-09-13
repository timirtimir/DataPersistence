using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.IO;
public class MenuManager : MonoBehaviour
{
    public string playerName;
    [SerializeField] private TMP_InputField nameField;
    [SerializeField] private TMP_Text highScoreText;

    private int highScore;
    private string highScoringPlayerName;

    private void Awake()
    {
        LoadHighScore();
        highScoreText.text = $"Best Score : {highScoringPlayerName} {highScore}";
    }
    public void StartGame()
    {
        PlayerManager.Instance.playerName = nameField.text;
        SceneManager.LoadScene(1);
    }
    [System.Serializable]
    class SaveData
    {
        public int highScore;
        public string playerName;
    }
    public void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            highScore = data.highScore;
            highScoringPlayerName = data.playerName;
        }
    }
}
