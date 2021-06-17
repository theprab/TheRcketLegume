using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ballCheck : MonoBehaviour
{
    public Rigidbody ball;
    public GameObject homeGoalPost1;
    public GameObject homeGoalPost2;
    public GameObject homeGoalTop;

    public GameObject awayGoalPost1;
    public GameObject awayGoalPost2;
    public GameObject awayGoalTop;

    public static int homeScore = 0;
    public static int awayScore = 0;

    public TextMeshPro homeScoreDisplay;
    public TextMeshPro awayScoreDisplay;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.transform.position.y < -0.5) {
            Vector3 newPos = new Vector3(-2.5f, 0.0f, 0.0f);
            ball.MovePosition(newPos);
            ball.velocity = Vector3.zero;

        }

        if (homeGoalScored() == true)
        {
            homeScore++;
            Debug.Log("Home: " + homeScore);
            Vector3 newPos = new Vector3(0.0f, 12.2f, 0.0f);
            ball.MovePosition(newPos);
            ball.velocity = Vector3.zero;
        }
        if (awayGoalScored() == true)
        {
            awayScore++;
            Debug.Log("Away: " + awayScore);
            Vector3 newPos = new Vector3(0.0f, 12.2f, 0.0f);
            ball.MovePosition(newPos);
            ball.velocity = Vector3.zero;
        }

        homeScoreDisplay.text = "Home: " + homeScore;
        awayScoreDisplay.text = "Away: " + awayScore;


    }
    bool homeGoalScored() {
        if (ball.transform.position.x <= homeGoalPost1.transform.position.x && (ball.transform.position.z <= homeGoalPost2.transform.position.z && ball.transform.position.z >= homeGoalPost1.transform.position.z) && (ball.transform.position.y <= homeGoalTop.transform.position.y)) {
            return (true);
        }
        else
        {
            return (false);
        }
    }

    bool awayGoalScored()
    {
        if (ball.transform.position.x >= awayGoalPost1.transform.position.x && (ball.transform.position.z <= awayGoalPost2.transform.position.z && ball.transform.position.z >= awayGoalPost1.transform.position.z) && (ball.transform.position.y <= awayGoalTop.transform.position.y))
        {
            return (true);
        }
        else
        {
            return (false);
        }
    }
}
