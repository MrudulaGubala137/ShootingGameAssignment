using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    float arrowSpped = 2f;
    // Start is called before the first frame update

    void Start()
    {
        // ShootingGame.PlayerMovement.onShootAction += TowardsPosition;
       // this.transform.position = tempPosition;
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(Vector3.right*arrowSpped*Time.deltaTime); 
    }
    private void OnBecameInvisible()
    {
        PoolManager.Instance.Recycle("Bullet", this.gameObject);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer==7)
        {
            ParticleManager.Instance.BlastEffect();
            PlayerMovement.Instance.UpdateScore(10);
            PoolManager.Instance.Recycle("Enemy", collision.gameObject);
            PoolManager.Instance.Recycle("Bullet", this.gameObject);
        }
        if(collision.gameObject.layer==8)
        {
            ParticleManager.Instance.ShootEffectFire();
            PoolManager.Instance.Recycle("Fire", collision.gameObject);
            PoolManager.Instance.Recycle("Bullet",this.gameObject);
        }
    }

}
