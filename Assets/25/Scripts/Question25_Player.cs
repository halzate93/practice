using UnityEngine;
using System.Collections;

public class Question25_Player : MonoBehaviour {

    public int health = 100;

    void Update()
    {
        if (health <= 0)
            Debug.Log("Game Over"); //Restart the game
        else
            Debug.Log("Health: " + health);
    }

    void OnCollisionEnter(Collision coll)
    {
        if(coll.gameObject.CompareTag("Bullet"))
        {
            Destroy(coll.gameObject); //It can be also a poll function
            MakeDamage(5);
        }
    }

    private void MakeDamage(int damage)
    {
        health -= damage;
    }
}