using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int sceneIndex;

    public void SceneChange()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
