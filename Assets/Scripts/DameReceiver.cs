using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DameReceiver : MonoBehaviour
{
    // Start is called before the first frame update
    protected int Hp = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public virtual void Receiver(int damage)
    {
        this.Hp -= damage;
    }

}
