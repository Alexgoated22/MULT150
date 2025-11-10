using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    private int bounceCount = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            bounceCount++;
            Debug.Log("Bounce count: " + bounceCount);
        }
    }
}