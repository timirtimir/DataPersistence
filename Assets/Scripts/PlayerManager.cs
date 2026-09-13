using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public string playerName;
    public static PlayerManager Instance;
    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
