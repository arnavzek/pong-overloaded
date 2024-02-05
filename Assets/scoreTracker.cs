using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoreTracker : MonoBehaviour
{

    public int player1Score = 0;
    public int player2Score = 0;

    public TMP_Text left;
    public TMP_Text right;
    // Start is called before the first frame update
    void Start()
    {
        right.text = "-";
        left.text = "-";

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(player2Score.ToString());
        Debug.Log(player2Score.ToString());

        if (collision.gameObject.tag == "Player1Boundry")
        {
            player2Score++;
            right.text = player2Score.ToString("0");
        }
        else if (collision.gameObject.tag == "Player2Boundry")
        {
            player1Score++;
            left.text = player1Score.ToString("0");
        }


    }
}
