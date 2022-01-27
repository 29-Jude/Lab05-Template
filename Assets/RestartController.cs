using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartController : MonoBehaviour
{
    public string SceneToLoad;

    private void Start()
    {
        Cursor.visible = true;
    }

    private void Update()
    {
        Cursor.visible = true;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneToLoad);
    }
}
