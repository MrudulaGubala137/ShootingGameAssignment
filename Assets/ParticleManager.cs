using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    [SerializeField]
    GameObject[] Particles=new GameObject[5];
   /* [SerializeField]
    GameObject blastParticle;
    [SerializeField]
    GameObject PlayerDeadParticle;
    [SerializeField]*/
    GameObject shootFireParticle;
    const string TURN_COROUTINE_FUNCTION = "WaitForSomeTime";
    // Start is called before the first frame update
    public static ParticleManager instance;
    public static ParticleManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = GameObject.FindObjectOfType<ParticleManager>();
                if (instance == null)
                {
                    GameObject container = new GameObject("Particle Manager");
                    instance = container.AddComponent<ParticleManager>();
                }
            }
            return instance;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShootEffect()
    {
        Particles[0].SetActive(true);
        StartCoroutine(TURN_COROUTINE_FUNCTION);
       Particles[0].SetActive(false);
    }
    public void BlastEffect()
    {
        Particles[1].SetActive(true);
        StartCoroutine(TURN_COROUTINE_FUNCTION);
        Particles[1].SetActive(false);
    }
    public void PlayerDeadEffect()
    {
        Particles[2].SetActive(true);
        StartCoroutine(TURN_COROUTINE_FUNCTION);
        Particles[2].SetActive(false);
    }
    public void ShootEffectFire()
    {
        Particles[3].SetActive(true);
        StartCoroutine(TURN_COROUTINE_FUNCTION);
        Particles[3].SetActive(false);
    }
    IEnumerator WaitForSomeTime()
    {
        yield return new WaitForSeconds(1);
    }
}
