using UnityEngine;
using UnityEngine.SceneManagement;

public class ConfigButton : MonoBehaviour
{
    // Método para cargar la escena de información
    public void LoadConfScene()
    {
        SceneManager.LoadScene("Conf"); // Reemplaza "InfoScene" con el nombre de tu escena de información.
    }
}
