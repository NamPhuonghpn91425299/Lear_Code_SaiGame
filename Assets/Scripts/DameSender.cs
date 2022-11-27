using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DameSender : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        DameReceiver dameReceiver = collision.GetComponent<DameReceiver>();
        dameReceiver.Receiver(1);

        //// khi cham vao tag player thi destroy enemy
        //if (collision.gameObject.CompareTag("Player"))
        //{
        //    Destroy(gameObject);
        //}

        Debug.Log("Dame Receiver");
    }

}
