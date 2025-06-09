using UnityEngine;

public class AudioScript : MonoBehaviour
{
    [Header("------ Audio Source ------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("------ Audio Clip ------")]
    public AudioClip background;
    public AudioClip flap;
    public AudioClip pointCollect;
    public AudioClip death;
    public AudioClip click;

    void Start() 
    {
        musicSource.clip = background;
        musicSource.Play();

    }

    public void playSFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
