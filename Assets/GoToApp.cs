using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

public class GoToApp : MonoBehaviour {

    private Manager_Master manager;

    void OnEnable()
    {
        SetInitialTReferences();
        manager.EventGoToApp += GoToAppScene;
    }

    void OnDisable()
    {
        manager.EventGoToApp -= GoToAppScene;
    }

    void SetInitialTReferences()
    {
        manager = GetComponent<Manager_Master>();
    }

    private void GoToAppScene()
    {
        SceneManager.LoadScene(2);
    }

}
