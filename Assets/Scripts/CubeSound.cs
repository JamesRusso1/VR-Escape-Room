using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSound : MonoBehaviour
{
    public AudioSource Sound;

    private void OnCollisionEnter(Collision collision)
    {
        Sound.Play();
    }
}
