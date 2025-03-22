using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject settingsPanel;
    private bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        pausePanel.SetActive(false);
        settingsPanel.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Continue();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Pause()
    {
        pausePanel.SetActive(true);
        isPaused = true;
        Time.timeScale = 0;
    }

    public void Continue() 
    { 
        pausePanel.SetActive(false);
        settingsPanel.SetActive(false );
        isPaused = false;
        Time.timeScale = 1;
    }

}