using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public void StartGame()
    {
        Application.LoadLevel("PlayMenu");
    }

    public void ExitGame()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void GoOptions()
    {
        Application.LoadLevel("Options");
    }
}
