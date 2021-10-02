using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneRestartManager : MonoBehaviour
{
    [SerializeField] GameObject confirmationPanel;

    public void ShowConfirmationPanel()
    {
        confirmationPanel.SetActive(true);
    }

    public void RestartMainScene()
    {
        confirmationPanel.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CancelRestarting()
    {
        confirmationPanel.SetActive(false);
    }
}
