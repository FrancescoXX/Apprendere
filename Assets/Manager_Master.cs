using UnityEngine;
using System.Collections;

public class Manager_Master : MonoBehaviour
{
    public delegate void ManagerSceneEventHandler();
    public event ManagerSceneEventHandler EventGoToApp;
    
    public void CallEventGoToApp()
        {
        if (EventGoToApp != null)
        {
            EventGoToApp();
        }
    }
}
