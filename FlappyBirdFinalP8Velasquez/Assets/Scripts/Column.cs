using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{
    private void OnTriggerEnter2D (Collision2D other)
    {
        if (other.GetComponent<Bird> () !+ null)
        {
            GameControl.instance.BirdScored();
        }
    }
}
