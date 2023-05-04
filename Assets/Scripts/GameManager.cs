using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    int score = 0;
    TMP_Text scoreUI;
    GameObject gesture;
    // Start is called before the first frame update
    void Start()
    {
        scoreUI = GameObject.FindGameObjectWithTag("ScoreUI").GetComponent<TextMeshProUGUI>();
        scoreUI.text = "Score: " + score;
        gesture = GameObject.FindWithTag("gesture");
        gesture.transform.setActive(false);
    }

    public void AddScore(int val){
        score += val;
        scoreUI.text = "Score: " + score;
    }
    public void setGesture(bool status){
        gesture.transform.setActive(status);
    }

}
