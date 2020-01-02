using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUD : MonoBehaviour
{
    public GameObject hud;

    public Text pointsText;
    public Text quadroText;

    public float quadro;

    public string scene;

    public bool pause;

    
    void Start()
    {
        hud.SetActive(false);
        pause = false;
       
    }

    
    void Update()
    {
        quadro += Time.deltaTime;
        pointsText.text = GameController.gameC.points.ToString();
        quadroText.text = Mathf.Floor(quadro*20).ToString();
    }

  
    public void Pause()
    {
        if (!pause)
        {
            hud.SetActive(true);
            pause = true;
            Time.timeScale = 0;
            Cannon.canon.speed = 0;
        }
        else
        {
            hud.SetActive(false);
            pause = false;
            Time.timeScale = 1;
            Cannon.canon.speed = 0.7f;
        }
        
    }
    public void ReloadingScene()
    {
        SceneManager.LoadScene(scene);
        Time.timeScale = 1;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
