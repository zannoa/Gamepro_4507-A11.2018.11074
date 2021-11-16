using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text MyScoreText;
    private int ScoreNum;

    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = 0;
        MyScoreText.text = "Score : " + ScoreNum;
    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D Coin) {

        if (Coin.tag == "coinTag") {

            ScoreNum += 1;
            Destroy(Coin.gameObject);
            MyScoreText.text = "Score :" + ScoreNum;
        }
    }
    
}
