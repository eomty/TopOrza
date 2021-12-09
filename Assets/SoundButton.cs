using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundButton : MonoBehaviour
{

    public GameObject SoundOnButton;
    public GameObject SoundOffButton;

    public AudioSource audioSource;
   public AudioClip BGM;

    // Start is called before the first frame update
    void Start()
    {
        
        audioSource.clip = BGM;

        audioSource.loop = true;
        audioSource.Play();
        SoundOnButton.SetActive(true);
        SoundOffButton.SetActive(false);
        audioSource.volume = 1.0f;
    }

  public void Off()
    {
        SoundOnButton.SetActive(false);
        SoundOffButton.SetActive(true);
        audioSource.volume = 0f;
    }
    public void On()
    {
        SoundOnButton.SetActive(true);
        SoundOffButton.SetActive(false);
        audioSource.volume = 1.0f;
    }
   
}
