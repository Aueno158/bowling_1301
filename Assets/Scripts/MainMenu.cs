using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
 public void StartGame()
    {
        SceneManager.LoadScene("Scene 01");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
