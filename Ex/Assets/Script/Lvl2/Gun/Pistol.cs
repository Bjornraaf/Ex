using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
    public AudioSource audioSource;

    public override void TriggerDown()
    {
        shoot();
        audioSource.Play();
    }
}
