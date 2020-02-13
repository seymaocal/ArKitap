using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using Vuforia;

public class SoundSetting : MonoBehaviour
{

    public AudioClip ses;
    public AudioSource source;

    public string butonsesadi;

    public void OnClicked(Button button)
    {

        sesCal();
       
    }
    public void OnClicked2(Button button)
    {
       
        sesCal();
    }

    public void OnClicked3(Button button)
    {

        sesCal();

    }

    private void sesCal()
    {
        if (source.isPlaying)
        {
            source.Stop();
        }
        string name = EventSystem.current.currentSelectedGameObject.name;
        print(name);
        ses = Resources.Load<AudioClip>("sound/" + name);
        print(ses);
        source.PlayOneShot(ses);

    }

   
}
