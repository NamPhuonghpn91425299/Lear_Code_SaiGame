using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroys : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyOBJ", 12f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void DestroyOBJ()
    {
        Destroy(gameObject);
    }
}
