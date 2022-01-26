using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliderController : MonoBehaviour
{
    public float CoinsToWin;
    public float CoinsCollected;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(CoinsCollected == CoinsToWin)
        {
            SceneManager.LoadScene("GameWin");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            CoinsCollected += 1;
            Destroy(collision.gameObject);
        }

        else if(collision.gameObject.tag == "Fire")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
