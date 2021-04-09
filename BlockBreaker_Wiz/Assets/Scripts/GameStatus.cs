using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour
{
    // config parameters
    [Range(0.1f,10f)][SerializeField] float gameSpeed = 1f;
    [SerializeField] int pointsPerBlockDestroyed = 10;
    [SerializeField] TextMeshProUGUI scoreText;
        
    // state variables
    [SerializeField] int currentScore = 0;


    private void Awake()
    {
        Debug.Log("GameStatus- Awake() Test1");
        int gameStatusCount = FindObjectsOfType<GameStatus>().Length;   //Singleton pattern
        if (gameStatusCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject); //possible error here.  try DestroyImmediate(gameObject) might work better. 
            Debug.Log("GameStatus- Awake() Test2");
        }
        else 
        {
            DontDestroyOnLoad(gameObject);
            Debug.Log("GameStatus- Awake() Test3");
        }
        Debug.Log("GameStatus- Awake() Test4");
    }

    private void Start()
    {
        scoreText.text = currentScore.ToString();
        Debug.Log("scoreText.text - GameStatus line35");
        
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
        Debug.Log("Time.timescale - GameStatus line43");
    }

    public void AddToScore()
    {
        // currentScore = currentScore + pointsPerBlockDestroyed; same as currentScore +=
        currentScore += pointsPerBlockDestroyed;
        Debug.Log(currentScore.ToString());
        //Debug.Log(scoreText.text + " :)");
        Debug.Log("AddToScore - GameStatus line 51");
        scoreText.text = currentScore.ToString();
        Debug.Log(currentScore.ToString());
        Debug.Log("AddToScore - GameStatus line 54");
        Debug.Log(scoreText.text + " ;)");
    }
}
