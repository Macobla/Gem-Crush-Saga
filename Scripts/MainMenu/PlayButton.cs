using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void LoadLevelSelection()
    {
        SceneManager.LoadScene("LevelSelection"); // Asegúrate de que el nombre coincida con el de tu escena
    }
}
