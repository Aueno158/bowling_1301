using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text scoreText;

    [SerializeField]    
    private TMP_Text winText;

    [SerializeField]   
     private int playerScore;

     public static GameManager Instance { get; private set; }

     private int fallenPinCount = 0;

     void Awake()
     {
        Instance = this;

        if (winText != null)
        {
            winText.gameObject.SetActive(false);
        }
     }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ShowScoreText(int n)
    {
        playerScore += n;
        scoreText.text = $"You did it! Score: {playerScore}";
          fallenPinCount++;
          if (fallenPinCount >= 9)
          {
              WinGame();
          }
    }

    private void WinGame()
    {
        if (winText != null)
        {
            winText.text = "You did great!";
            winText.gameObject.SetActive(true);
        }
    }

    public void ShowString(string text)
    {
        scoreText.text = text;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}