using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen2 : MonoBehaviour
{
    public GameObject Door;
    private bool isCollected = false;
    public int x = 5;
    public int y = 5;
    public int z = 5;


    void OnTriggerEnter(Collider other)
    {
        if (!isCollected)
        {
            Door.gameObject.transform.position = new Vector3(x, y, z);
            Destroy(gameObject);
            isCollected = true;
        }
    }
}