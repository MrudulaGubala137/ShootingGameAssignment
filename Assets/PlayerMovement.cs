using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class PlayerMovement : MonoBehaviour
    {
        // Start is called before the first frame update
      
            public float moveSpeed = 5f;
        public new Vector3 offSet;
        public Rigidbody2D rb;
        int score = 0;
        // Update is called once per frame
        void Update()
        {
            // movement.x = Input.GetAxisRaw("Horizontal");
            float movementY = Input.GetAxisRaw("Vertical");
            transform.Translate(0f, movementY * moveSpeed * Time.deltaTime, 0f);
            if (Input.GetMouseButtonDown(0))
            {
                GameObject tempArrow = PoolManager.Instance.Spawn("Bullet");
                tempArrow.transform.position = this.transform.position+offSet;
               
            }

        }
        public void UpdateScore(int value)
        {
            score=score+value;
            print("Score:"+score);
        }

       
    }


