using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource[] audioSources;

    private void Awake()
    {
        audioSources = GetComponents<AudioSource>();
    }

    private void Start()
    {
        if (audioSources.Length < 2)
            return;

        audioSources[0].Stop();
        audioSources[1].Stop();

        audioSources[0].Play();

        Invoke(nameof(StartNormalGhostMusic), 3f);
    }

    private void StartNormalGhostMusic()
    {
        if (audioSources.Length < 2)
            return;

        audioSources[0].Stop();
        audioSources[1].Play();
    }
}