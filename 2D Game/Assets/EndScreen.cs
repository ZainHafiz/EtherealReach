using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    public GameObject EndScreenPanel;
    public GameObject EndScreenTextObjects;
    public Animator animator;

    public void DisplayEndScreenPanel()
    {
        EndScreenPanel.SetActive(true);
        animator.SetBool("HasEnded", true);
    }

    public void DisplayTextObjects()
    {
        Time.timeScale = 0;
        EndScreenTextObjects.SetActive(true);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
}
