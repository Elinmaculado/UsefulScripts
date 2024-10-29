using UnityEngine;
using UnityEngine.SceneManagement;

// Remember to add the desired scenes to build settings
public class SceneChanger : MonoBehaviour
{
    public void loadGame()
    {
        SceneManager.LoadScene("Level");
    }

    public void loadMenu()
    {
        SceneManager.LoadScene("MainMenu");

    }
}