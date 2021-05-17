using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class kadai : MonoBehaviour
{
    private int score = 0;
    private GameObject ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        this.ScoreText = GameObject.Find("ScoreText");
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "SmallStarTag")
        {
            this.score += 100;
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            this.score += 150;
        }
        else if (other.gameObject.tag == "SmallCloudTag" || other.gameObject.tag == "LargeCloudTag")
        {
            this.score += 200;
        }
        this.ScoreText.GetComponent<Text>().text = score.ToString();
    }
}
