using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gameButtons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void appStart()
    {
        SceneManager.LoadScene("startScene");

    }
    public void appLoad()
    {
        SceneManager.LoadScene("loadScene");
    }
    public void appOptions() {
        SceneManager.LoadScene("optionsScene");
    
    }
    public void appQuit()
    {
        Application.Quit();

    }
}
