using UnityEngine;
using UnityEngine.SceneManagement;

public class TutButton : MonoBehaviour
{
    public void LoadTutorial()
    {
        SceneManager.LoadScene("Tut");
    }
}
