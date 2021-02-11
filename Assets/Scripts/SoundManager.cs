using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    static AudioSource audioSource;

    #region Static Audio Clips
    public static AudioClip coinPickUp;
    public static AudioClip death;
    #endregion

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        coinPickUp = Resources.Load<AudioClip>("CoinPickUp");
        death = Resources.Load<AudioClip>("Death");
    }

    public static void PlaySound(string _clip)
    {
        switch (_clip)
        {
            case "CoinPickUp":
                audioSource.PlayOneShot(coinPickUp);
                break;

            case "Death":
                audioSource.PlayOneShot(death);
                break;

            default:
                break;
        }
    }
}