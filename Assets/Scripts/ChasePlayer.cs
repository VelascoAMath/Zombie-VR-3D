using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasePlayer : MonoBehaviour
{

    public GameObject player;
    public GameObject deathMessage;

    void Start()
    {
        deathMessage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!deathMessage.activeSelf)
        {
            Vector3 distance = player.transform.position - gameObject.transform.position;
            distance.y = 0.0f;
            //Debug.Log(distance);
            if (distance.magnitude < 1.0f)
            {
                //Destroy(player);
                //player.SetActive(false);
                //deathMessage.SetActive(true);
                //this.gameObject.SetActive(false);
            }
            if (true)
            {
                gameObject.GetComponent<Transform>().LookAt(player.transform.position);
                gameObject.GetComponent<Transform>().Translate(Vector3.forward / 30);
                gameObject.GetComponent<Transform>().position = gameObject.transform.position + distance / 400.0f;
                //gameObject.GetComponent<Transform>().Translate(gameObject.transform.position + distance / 1000.0f - new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z));

            }
            //else
            //{
            //    Vector3 randomLook = new Vector3(Random.Range(-1, 1), 0, Random.Range(-1, 1));
            //    gameObject.GetComponent<Transform>().LookAt(randomLook);
            //    gameObject.GetComponent<Transform>().Translate(randomLook);

            //}

        }
    }
}
