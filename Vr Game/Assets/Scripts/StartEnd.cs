using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartEnd : MonoBehaviour
{
    public GameObject StartCanvas;
    public GameObject PauseCanvas;
    public Animator transition;
    // Start is called before the first frame update
    void Start()
    {
        transition.SetTrigger("Start");
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();

        }
    }
    public void StartButton()
    {
        StartCanvas.SetActive(false);
        Time.timeScale = 1;

    }
    public void PauseGame()
    {
        PauseCanvas.SetActive(true);
        Debug.Log("TimeSlowed");
        Time.timeScale = 0;

    }
    public void ContinueGame()
    {
        PauseCanvas.SetActive(false);
        Time.timeScale = 1;
        Debug.Log("TimeBack");

    }
}
