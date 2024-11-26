using UnityEngine;

public class BoardManager : MonoBehaviour
{
    public int width = 8;  // Ancho del tablero
    public int height = 8; // Alto del tablero
    public GameObject[] gemPrefabs; // Prefabs de las gemas
    public RectTransform boardHolder; // Referencia al objeto padre donde se colocarán las gemas (dentro del Canvas)
    public float cellSize = 100f; // Tamaño de las celdas (ajústalo según tus necesidades)

    void Start()
    {
        CreateBoard();
    }

    void CreateBoard()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                // Seleccionar una gema aleatoria
                int gemIndex = Random.Range(0, gemPrefabs.Length);

                // Instanciar la gema como un hijo del objeto boardHolder
                GameObject gem = Instantiate(gemPrefabs[gemIndex], boardHolder);

                // Asegurarse de que la gema tiene un RectTransform
                RectTransform rectTransform = gem.GetComponent<RectTransform>();
                if (rectTransform != null)
                {
                    // Posiciona la gema dentro del Canvas usando las coordenadas correctas
                    rectTransform.anchoredPosition = new Vector2(x * cellSize, y * cellSize);
                    rectTransform.localScale = Vector3.one;  // Asegurarse de que la escala es 1 para evitar problemas de escalado
                }
                else
                {
                    Debug.LogError("El prefab de la gema no tiene un RectTransform. Asegúrate de que es un UI element.");
                }
            }
        }
    }
}
