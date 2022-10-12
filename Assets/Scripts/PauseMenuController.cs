using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class PauseMenuController : MonoBehaviour
{
    public GameObject[] PauseMenuObjects;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        PauseMenuObjects = GameObject.FindGameObjectsWithTag("PauseMenu");

        foreach (GameObject g in PauseMenuObjects)
        {
            g.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                foreach (GameObject g in PauseMenuObjects)
                {
                    g.SetActive(true);
                    
                }
            }
            else if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
                foreach (GameObject g in PauseMenuObjects)
                {
                    g.SetActive(false);
                }
            }
        }
        if (Input.GetKeyDown("r"))
            SceneManager.LoadScene("SampleScene");
    }
}
