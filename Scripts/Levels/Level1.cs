using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1 : MonoBehaviour
{
    // Método para cargar la escena de información
    public void LoadInfoScene()
    {
        SceneManager.LoadScene("Level 1"); // Reemplaza "InfoScene" con el nombre de tu escena de información.
    }
}
