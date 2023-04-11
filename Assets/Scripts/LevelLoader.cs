using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public bool switchLevel;
    public EndController fin;

    public Animator transition;

    // Update is called once per frame
    void Update()
    {
        switchLevel = fin.endBool;

        if (switchLevel)
        {
            LoadNextlevel();
        }
    }

    private void LoadNextlevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(1);
        
        SceneManager.LoadScene(levelIndex);
    }
}
