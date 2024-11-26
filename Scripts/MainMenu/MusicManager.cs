using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static MusicManager instance = null;  // Singleton instance

    private AudioSource audioSource;

    private void Awake()
    {
        // Singleton pattern to ensure only one instance of MusicManager exists
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);  // Keeps the MusicManager across scenes
        }
        else
        {
            Destroy(gameObject);  // Destroy duplicate instances
        }
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // Check if AudioSource exists and start playing music
        if (audioSource != null && !audioSource.isPlaying)
        {
            audioSource.loop = true;  // Make sure the music loops
            audioSource.Play();
        }
    }

    // Method to set the music volume
    public void SetMusicVolume(float volume)
    {
        if (audioSource != null)
        {
            audioSource.volume = volume;
        }
    }
}
