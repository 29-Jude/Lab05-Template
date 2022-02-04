using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliderController : MonoBehaviour
{
    public float CoinsToWin;
    public float CoinsCollected;
    public Transform Particle;

    // Start is called before the first frame update
    void Start()
    {
        Particle.GetComponent<ParticleSystem>().Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if(CoinsCollected >= CoinsToWin)
        {
            SceneManager.LoadScene("GameWin");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject);
            CoinsCollected += 1;
            Particle.GetComponent<ParticleSystem>().Play();
            
        }

        else if(other.gameObject.tag == "Fire")
        {
            SceneManager.LoadScene("GameLose");
        }
    }
}
