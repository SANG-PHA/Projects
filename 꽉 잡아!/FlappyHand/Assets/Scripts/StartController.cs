using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class StartController : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    /*private void Update()
    {
        bool tap = false;
        if (Input.GetKeyDown("space") || Input.GetMouseButtonDown(0)) tap = true;
        if (tap){
            SceneManager.LoadScene("Main");
        }
    }*/
    public void StartGame(){
        SceneManager.LoadScene("Main");
    }
    public void QuitGame(){
        EditorApplication.Exit(0);
    }
}
