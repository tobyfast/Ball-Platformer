using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manager : MonoBehaviour
{
    public int score;
    public static manager inst;

    public Text scoreText;

    public void IncreamentScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }


    private void Awake()
    {
        inst = this;

    }

    private void Start()
    {

    }


    private void Update()
    {

    }
}
