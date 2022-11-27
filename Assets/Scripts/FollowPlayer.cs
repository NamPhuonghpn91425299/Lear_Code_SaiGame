using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    protected float speed = 5f;
    protected float distance = 0.5f;
    void Start()
    {
        //Invoke("enemyFollow", 10f);
    }

    // Update is called once per frame
    void Update()
    {

        this.enemyFollow();
    }
    void enemyFollow()
    {
         Vector3 distance = player.position - transform.position;
         if (distance.magnitude >= this.distance)
        {
         Vector3 targetPoint = player.position - distance.normalized * this.distance;
         gameObject.transform.position =
             Vector3.MoveTowards(gameObject.transform.position, targetPoint, this.speed * Time.deltaTime);
        }
    }
}
