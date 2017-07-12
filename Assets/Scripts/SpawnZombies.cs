using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZombies : MonoBehaviour
{

    public GameObject player;
    public GameObject zombie;
    private HashSet<GameObject> zombieList;
    private float spawnTime;

    // Use this for initialization
    void Start()
    {
        spawnTime = Time.time;
        zombieList = new HashSet<GameObject>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (zombieList.Count < 250 && Time.time - spawnTime > 0.3f)
        {
            Vector3 randomLoc = Random.onUnitSphere * 50;
            randomLoc.y = 0;
            spawnTime = Time.time;
            GameObject newZombie = Instantiate(zombie, player.transform.position + randomLoc, new Quaternion());
            zombieList.Add(newZombie);

        }
        else
        {
            if (Time.time - spawnTime > 0.1f)
            {
                //spawnTime = Time.time;
               
              foreach( GameObject z in zombieList)
                {
                    if (z == null)
                    {
                        zombieList.Remove(z);
                        break;
                    }
                }
            }
        }

    }
}