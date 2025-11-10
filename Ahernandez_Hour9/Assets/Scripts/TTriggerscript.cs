using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TTriggerScript : MonoBehaviour
{
    private void OnTTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log($"ENTERED {gameObject.name}");
        }
    }

    private void OnTTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log($"STAYING in {gameObject.name}");
        }
    }

    private void OnTTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log($"EXITED {gameObject.name}");
        }
    }
}