using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedestalscript : MonoBehaviour
{
    public static int Points;

    public GameObject Door;

    public AudioSource Notification;

    void Start()
    {
        Points = 0;
    }


    void Update()
    {
        if (Points == 3)
        {
            Door.SetActive(false);
        }
    }

    //functions to put in the Socket menu
    public void AddPoints()
    {
        Points++;
    }
    public void SubtractPoints()
    {
        Points--;
    }

    public void ColorRed()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
    public void ColorOrange()
    {
        GetComponent<MeshRenderer>().material.color = new Color(0.95f, 0.5f, 0.1f);
    }
    public void ColorYellow()
    {
        GetComponent<MeshRenderer>().material.color = Color.yellow;
    }

    public void PlaySound()
    {
        Notification.Play();
    }


}
