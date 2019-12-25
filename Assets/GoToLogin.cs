using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoToLogin : MonoBehaviour
{
    public Scrollbar myScrollbar;

    // Use this for initialization
	void Start ()
    {
        
        Invoke("Carica", 3f);
	}
	
    void Carica()
    {
        SceneManager.LoadScene(1);
    }

    void Update()
    {
        myScrollbar.size = Time.time * 0.3f;
    }

}
