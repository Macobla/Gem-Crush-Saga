using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler2 : MonoBehaviour
{
    // Método para cargar la escena de información
    public void LoadInfoScene()
    {
        SceneManager.LoadScene("MainMenu"); // Reemplaza "InfoScene" con el nombre de tu escena de información.
    }
}
