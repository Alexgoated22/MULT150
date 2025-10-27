using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int x = TakeDamageFromFireball();
        print("Player health: " + x);

        int y = TakeDamageFromFireball(25);
        print("Player health: " + y);

        int z = TakeDamageFromFireball(30, 75);
        print("Player health: " + z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int TakeDamageFromFireball()
    {
        int health = 100;
        int damage = 10;
        return health - damage;
    }
    int TakeDamageFromFireball(int damage)
    {
        int health = 100;
        return health - damage;
    }
    int TakeDamageFromFireball(int damage, int playerHealth)
    {
        return playerHealth - damage;
    }
}
