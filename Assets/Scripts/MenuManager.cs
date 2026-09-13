using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class MenuManager : MonoBehaviour
{
    public string playerName;
    [SerializeField] private TMP_InputField nameField;

    public void StartGame()
    {
        PlayerManager.Instance.playerName = nameField.text;
        SceneManager.LoadScene(1);
    }
}
