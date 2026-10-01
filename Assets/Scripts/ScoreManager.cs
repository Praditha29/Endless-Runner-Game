using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public Text scoreText; //to display the player's score
    private float score; //to store the player's score

    
    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") != null)
        {
            score += 1 * Time.deltaTime;
            scoreText.text = ((int)score).ToString(); //so that float value is converted to integer and then to string value
        }
    }
}
