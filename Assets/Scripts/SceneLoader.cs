using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex+1);

     /*   int liczbaScen = SceneManager.sceneCountInBuildSettings;

        if(currentSceneIndex == 3)
        {
            currentSceneIndex = 0;
        }
        */
    }

    public void LoadStartScene()
    {
      SceneManager.LoadScene(0);
    }



    public void ChangeColor()
    {
     //   var colors = GetComponent<Button>().colors;
    //    colors.normalColor = Color.red;
    //    GetComponent<Button>().colors = colors;
    }

    public void OptionButton()
    {
        SceneManager.LoadScene(3);

    }

    public void BackFromOptionButton()
    {
        SceneManager.LoadScene(0);

    }

    public void QuitButton()
    {
        Application.Quit();
    }

}
