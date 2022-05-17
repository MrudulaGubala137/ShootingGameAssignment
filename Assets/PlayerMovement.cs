using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


    public class PlayerMovement : MonoBehaviour
    {
    // Start is called before the first frame update
    
            public float moveSpeed = 5f;
        public new Vector3 offSet;
        public Rigidbody2D rb;
        int score = 0;
        int lives = 5;
        public bool isWon;
        public Text livesText;
       public Text scoreText;
       public bool isGameOver;
    [SerializeField]
    GameObject gameOverObject;
    // Update is called once per frame
    public static PlayerMovement instance;
    public static PlayerMovement Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<PlayerMovement>();

                if (instance == null)
                {
                    GameObject container = new GameObject("Player");
                    instance = container.AddComponent<PlayerMovement>();
                }
            }

            return instance;
        }
    }
    private void Start()
    {

        gameOverObject.SetActive(false);
    }
    void Update()
        {
       
            // movement.x = Input.GetAxisRaw("Horizontal");
            float movementY = Input.GetAxisRaw("Vertical");
            transform.Translate(0f, movementY * moveSpeed * Time.deltaTime, 0f);
            if (Input.GetMouseButtonDown(0))
            {
                GameObject tempArrow = PoolManager.Instance.Spawn("Bullet");
                tempArrow.transform.position = this.transform.position + offSet;

            }
            if(isGameOver)
            {
            gameOverObject.SetActive(true);
            GameManager.Instance.GameOver();
            this.gameObject.SetActive(false);
            }
        
        }
    public void LostLife(int life)
    {
           lives = lives - life;
            print("life"+lives);
            livesText.text = lives.ToString();
        if(lives == 0)
        {
            isGameOver = true;
            isWon = false;
        }
        
    }
    public void UpdateScore(int value)
        {
        if(score==100)
        {
            isGameOver = true;
           
            isWon = true;
        }
            score=score+value;
            print("Score:"+score);
            scoreText.text = score.ToString();
        
        }
    

       
    }
    


