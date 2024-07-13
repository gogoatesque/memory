using UnityEngine;

public class PlayMenu : MonoBehaviour
{
    public void Tutorial()
    {
        Application.LoadLevel("Level0");
    }

    public void Level()
    {
        Application.LoadLevel("Level");
    }

    public void GoBack()
    {
        Application.LoadLevel("Menu");
    }
}
