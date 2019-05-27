using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCalc : MonoBehaviour {

	//得点
	public int score = 0;
	//得点テキスト
	public GameObject scoreText;

	// Use this for initialization
	void Start () {
		//得点テキストを取得
		this.scoreText = GameObject.Find("ScoreText");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
    void OnCollisionEnter(Collision other) {
		if (tag == "SmallStarTag") {
            score+=5;
    	}else if(tag == "SmallCloudTag") {
            score+=10;
        }else if(tag == "LargeCloudTag") {
            score+=20;
        } else if (tag == "LargeStarTag") {
            score+=50;
        }
		this.scoreText.GetComponent<Text> ().text = "Score = "+score;

        Debug.Log("Score = "+tag);
    }
}
