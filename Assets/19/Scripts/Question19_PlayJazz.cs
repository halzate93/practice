using UnityEngine;
using System.Collections;

public class Question19_PlayJazz : MonoBehaviour {

    [SerializeField]
    private AudioSource audioFile;

    public void Play()
    {
        audioFile.Play();
    }

    public void AjustableVolume(float volume)
    {
        audioFile.volume = volume;
    }
}