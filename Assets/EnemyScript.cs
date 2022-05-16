using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      transform.Translate(Vector3.left * 1 * Time.deltaTime);
        time=time+Time.deltaTime;
        if(time>3f)
        {
            SpawnManager.Instance.SpawnFire(this.transform.position);
            time = 0;
        }
        if(transform.position.x < -8f)
        {
            PoolManager.Instance.Recycle("Enemy", this.gameObject);
        }

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            PoolManager.Instance.Recycle("Enemy", this.gameObject);
        }
    }


}
