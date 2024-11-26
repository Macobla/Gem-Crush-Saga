using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public Button[] levelButtons; // Un array de botones para los niveles

    void Start()
    {
        // Cargar el nivel alcanzado, por defecto es el nivel 1
        int levelReached = PlayerPrefs.GetInt("LevelReached", 1);

        // Iterar sobre cada botón de nivel
        for (int i = 0; i < levelButtons.Length; i++)
        {
            // Todos los niveles son visibles, pero solo los desbloqueados son interactivos
            if (i + 1 <= levelReached) // Desbloqueado si el nivel es menor o igual al alcanzado
            {
                levelButtons[i].interactable = true; // Nivel disponible
                levelButtons[i].GetComponent<Image>().color = Color.white; // Color activo
            }
            else
            {
                levelButtons[i].interactable = false; // Nivel bloqueado
                levelButtons[i].GetComponent<Image>().color = Color.gray; // Color bloqueado
            }
        }
    }

    // Método que se llama al completar un nivel
    public void CompleteLevel(int level)
    {
        int currentLevelReached = PlayerPrefs.GetInt("LevelReached", 1);

        // Si se ha completado un nivel mayor o igual al nivel alcanzado, actualizar el progreso
        if (level >= currentLevelReached)
        {
            PlayerPrefs.SetInt("LevelReached", level + 1);
        }
    }

    // Método para restablecer el progreso (solo para pruebas)
    public void ResetProgress()
    {
        PlayerPrefs.SetInt("LevelReached", 1); // Restablecer al nivel 1
    }
}
