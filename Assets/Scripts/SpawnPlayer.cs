using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    float playerPosX;
    private List<GameObject> minions;
    public GameObject minionPrefab;
    protected float spawmTimer = 0f;
    protected float spawmDelay = 0f;
    void Start()
    {
        this.minions = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
        this.Spawn();
        
 
        this.CheckMinionDead();
    }

    void Spawn()
    {
        Debug.Log("Spawn Minion");

        this.spawmTimer += Time.deltaTime;
        if (this.spawmTimer < this.spawmDelay) return; // delay time spawn
        this.spawmTimer = 0;

        if (this.minions.Count >= 7)
        {
            return;
        }
        int index = this.minions.Count + 1; // dem enemy spaw

        GameObject minion = Instantiate(this.minionPrefab); // clone bot voi prefab
        minion.name = "MinionPrefab " + index; // danh so dem voi bo clone

        minion.transform.position = transform.position; // spawn lay vi tri nhan vat
        minion.gameObject.SetActive(true); // bat gameobject len tranh vc destroy lamf missing object
        this.minions.Add(minion);
    }

    void NotSpawn()
    {
        Debug.Log("Not Spawn");

    }

    void CheckMinionDead()
    {
        GameObject minion;
        for (int i = 0; i < this.minions.Count; i++)
        {
            minion = this.minions[i];
            if (minion == null) this.minions.RemoveAt(i);
        }
        Debug.Log("remove add");
    }


}
