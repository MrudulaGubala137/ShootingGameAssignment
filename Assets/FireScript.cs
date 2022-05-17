using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left*2*Time.deltaTime);
        if (transform.position.x < -8f|| PlayerMovement.Instance.isGameOver == true)
        {
            PoolManager.Instance.Recycle("Fire", this.gameObject);
        }
       
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            PlayerMovement.Instance.LostLife(1);
            PoolManager.Instance.Recycle("Fire", this.gameObject);
        }
    }
    
    
}
