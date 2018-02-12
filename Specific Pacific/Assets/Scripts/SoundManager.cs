using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip s1, s2;
    static AudioSource audioSrc;

    // Use this for initialization
    void Start()
    {
        s1 = Resources.Load<AudioClip>("Sound1");
        s2 = Resources.Load<AudioClip>("Sound2");

        audioSrc = GetComponent<AudioSource>();

        DontDestroyOnLoad(gameObject);
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "Sound1":
                audioSrc.PlayOneShot(s1);
                break;

            case "Sound2":
                audioSrc.PlayOneShot(s2);
                break;
        }
    }
}
