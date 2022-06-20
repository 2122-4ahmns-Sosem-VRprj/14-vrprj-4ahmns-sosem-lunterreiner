using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour
{
    public GameObject EndOject;
    private bool Sound = false;
    public AudioClip EndSound;

    private void OnTriggerEnter(Collider other)
    {
        if (EndSound == true)
        {
            Sound = true;
        }
    }
}
