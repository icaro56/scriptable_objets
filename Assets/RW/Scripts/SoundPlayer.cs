using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    public AudioSource efxSource;

    //Used to play single sound clips.
    public void Play()
    {
        //Play the clip.
        efxSource.Play();
    }
}