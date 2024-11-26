using UnityEngine;

public class ExitButton : MonoBehaviour
{
    // Este método se llamará cuando el botón sea clickeado
    public void OnExitButtonClick()
    {
        #if UNITY_EDITOR
        // En el editor de Unity, detiene la ejecución del juego
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        // En un build de la aplicación, cierra la aplicación
        Application.Quit();
        #endif
    }
}
