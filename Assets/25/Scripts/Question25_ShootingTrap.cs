using UnityEngine;
using System.Collections;

public class Question25_ShootingTrap : MonoBehaviour {

    [SerializeField]
    private float bulletVelocity = 10;
    [SerializeField]
    private float bulletSpawnTime = 1;
    private float bulletSpawnTimeTemp;

    [SerializeField]
    private GameObject bulletPrefab;
    [SerializeField]
    private Transform[] spawnBullets = new Transform[3]; //Is an array because we know the spawnBullets transform size

    void Start()
    {
        bulletSpawnTimeTemp = bulletSpawnTime;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            bulletSpawnTime -= Time.deltaTime;

            if (bulletSpawnTime <= 0)
            {
                for (int i = 0; i < spawnBullets.Length; i++)
                {
                    SpawnBullet(i);
                }
                bulletSpawnTime = bulletSpawnTimeTemp;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            DestroyBullet(other.gameObject);
        }
        else
        {
            bulletSpawnTime = bulletSpawnTimeTemp;
        }
    }

    //It can be also a pool function
    private void SpawnBullet(int i)
    {
        GameObject bullet = Instantiate(bulletPrefab, spawnBullets[i].position, spawnBullets[i].rotation) as GameObject;
        bullet.GetComponent<Rigidbody>().velocity = bulletVelocity * -transform.right;
    }

    //It can be also a pool function
    private void DestroyBullet(GameObject bullet)
    {
        Destroy(bullet);
    }
}