using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    float time;
    public static SpawnManager instance;
    public static SpawnManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<SpawnManager>();
                if (instance == null)
                {
                    GameObject container = new GameObject("Spawn Manager");
                    instance = container.AddComponent<SpawnManager>();
                }
            }
            return instance;
        }
    }
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if (time > 5f)
        {
            GameObject tempEnemy = PoolManager.Instance.Spawn("Enemy");
            tempEnemy.transform.position = new Vector3(8f, Random.Range(-3f, 3f), 0f);
            time = 0;
        }
    }
    public void SpawnFire(Vector3 enemyPosition)
    {
        ParticleManager.Instance.ShootEffect();
        GameObject tempFire = PoolManager.Instance.Spawn("Fire");
        tempFire.transform.position = enemyPosition+new Vector3(-2f,0f,0f);
    }
}
