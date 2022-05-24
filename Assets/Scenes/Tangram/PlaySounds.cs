using UnityEngine;

public class PlaySounds : MonoBehaviour
{
    public AudioClip wrongMove;
    public AudioClip correctMove;
    public AudioClip congrats;
    public AudioClip rotate;
    public AudioClip selected;

    AudioSource soundSource;
    // Use this for initialization
    void Start()
    {
        var soundSources = GetComponents<AudioSource>();
        soundSource = soundSources[0];
    }

    public void Congrats()
    {
        soundSource.PlayOneShot(congrats);
    }

    public void WrongMove()
    {
        soundSource.PlayOneShot(wrongMove);
    }

    public void CorrectMove()
    {
        soundSource.PlayOneShot(correctMove);
    }

    public void Rotate()
    {
        soundSource.PlayOneShot(rotate);
    }

    public void Selected()
    {
        soundSource.PlayOneShot(selected);
    }
}
