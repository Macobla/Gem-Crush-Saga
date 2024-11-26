using UnityEngine;
using UnityEngine.SceneManagement;

public class InfoButton : MonoBehaviour
{
    // Método para cargar la escena de información
    public void LoadInfoScene()
    {
        SceneManager.LoadScene("Info"); // Reemplaza "InfoScene" con el nombre de tu escena de información.
    }
}
