using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    static int currentSceneIndex = 0;
    string nextLevelName;

    private void Start()
    {
        Debug.Log(currentSceneIndex);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            LoadNextLevel();
        }
    }

    private void LoadNextLevel()
    {
        if (currentSceneIndex == 0)
        {
            nextLevelName = "Lvl_2";
        }

        if (currentSceneIndex == 1)
        {
            nextLevelName = "Lvl_3";
        }
        if (currentSceneIndex == 2)
        {
            nextLevelName = "Lvl_4";
        }

        SceneManager.LoadScene(nextLevelName);
        currentSceneIndex += 1;
    }
}
