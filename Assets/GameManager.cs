using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    GameObject arrow;
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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ArrowSpawn()
    {
        

        //tempArrow.transform.position = mousePosition;

    }
}
