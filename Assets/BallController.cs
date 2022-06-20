using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    private float visiblPosZ = -6.5f;

    private GameObject gameoverText;

    private int score = 0;

    private GameObject scoreText;

    // Start is called before the first frame update
    void Start()
    {
        this.gameoverText = GameObject.Find("GameOverText");

        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {

        this.scoreText.GetComponent<Text>().text = score.ToString();

        if (this.transform.position.z < this.visiblPosZ)
        {
            this.gameoverText.GetComponent<Text> ().text = "Game Over";
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "LargeStarTag" )
        {
            score += 30;
        }

        if (collision.gameObject.tag == "SmallSaarTag")
        {
            score += 10;
        }

        if (collision.gameObject.tag == "LargeCloudTag")
        {
            score += 100;
        }

        if (collision.gameObject.tag == "SmallCloudTag")
        {
            score += 40;
        }
    }
}
