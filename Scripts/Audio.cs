using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{

    static AudioSource audioSource;
    public static AudioClip UIClip;
    public static AudioClip hitRockClip;
    public static AudioClip getItemClip;
    public static AudioClip fallClip;
    public static AudioClip outOfHealthClip;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        UIClip = Resources.Load<AudioClip>("button_press_01");
        getItemClip = Resources.Load<AudioClip>("collect_01");
        hitRockClip = Resources.Load<AudioClip>("error_01");
        fallClip = Resources.Load<AudioClip>("funny_fall_01");
        outOfHealthClip = Resources.Load<AudioClip>("cute_modulated_drop_01");
    }

    public static void UISoundPlay()
    {
        audioSource.PlayOneShot(UIClip);
    }
    public static void RockSoundPlay()
    {
        audioSource.PlayOneShot(hitRockClip);
    }
    public static void ItemSoundPlay()
    {
        audioSource.PlayOneShot(getItemClip);
    }
    public static void fallSoundPlay()
    {
        audioSource.PlayOneShot(fallClip);
    }
    public static void HealthSoundPlay()
    {
        audioSource.PlayOneShot(outOfHealthClip);
    }

}
