using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update

    void Awake()
    {
        Time.timeScale = 0.0f;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0.0f && Input.GetKeyDown(KeyCode.R)){
            Debug.Log("Game Restarting...");
            SceneManager.LoadScene( SceneManager.GetActiveScene().name );
        }
    }

    public void StartButtonClicked(){
        foreach (Transform eachChild in transform){
            if (eachChild.name != "Score"){
                Debug.Log("Child found. Name: " + eachChild.name);
                eachChild.gameObject.SetActive(false);
                Time.timeScale = 1.0f;
            }
        }
    }
}
