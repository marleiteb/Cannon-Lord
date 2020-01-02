using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public static GameController gameC;

    public GameObject startButton;

    public int points;
    public int quadros;


    private void Awake()
    {
        Time.timeScale = 0;
        gameC = this;
    }
    void Start()
    {
       
        
    }

    public void StartButton()
    {
        Time.timeScale = 1;
        Cannon.canon.speed = 0.7f;
        startButton.SetActive(false);
      
    }
    
    void Update()
    {
        
    }
}
