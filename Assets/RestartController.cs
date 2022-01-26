using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartController : MonoBehaviour
{
    public string SceneToLoad;

    public void Restart()
    {
        SceneManager.LoadScene(SceneToLoad);
    }
}
