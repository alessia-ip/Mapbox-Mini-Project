using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReachedSpawnPoint : MonoBehaviour
{

    public GameObject but;

    public ChangeScene _ChangeScene;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SpawnSite")
        {
            but.SetActive(true);
            if (other.gameObject.name.Contains("1"))
            {
                _ChangeScene.sceneIndex = 1;
            }
            else
            {
                _ChangeScene.sceneIndex = 2;
            }
        }
    }
    
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "SpawnSite")
        {
            but.SetActive(true);
            if (other.gameObject.name.Contains("1"))
            {
                _ChangeScene.sceneIndex = 1;
            }
            else
            {
                _ChangeScene.sceneIndex = 2;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "SpawnSite")
        {
            but.SetActive(false);
        }
    }
}
