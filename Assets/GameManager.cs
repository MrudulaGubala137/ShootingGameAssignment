using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{


    [SerializeField]
    Text wonLostText;
    [SerializeField]
    Button playAgain;
    [SerializeField]
    Button back;

    public static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<GameManager>();
                if (instance == null)
                {
                    GameObject container = new GameObject("Game Manager");
                    instance = container.AddComponent<GameManager>();
                }
            }
            return instance;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        playAgain.onClick.AddListener(PlayAgain);
        back.onClick.AddListener(Back);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameOver()
    {
        
        if (PlayerMovement.Instance.isWon == true)
        {
            wonLostText.text = "YOU WON!!!!!";
        }
        else
            wonLostText.text = "YOU LOST!!!!!";

    }
    private void PlayAgain()
    {
        SceneManager.LoadScene(1);
    }
    private void Back()
    {
        SceneManager.LoadScene(0);
    }
}
