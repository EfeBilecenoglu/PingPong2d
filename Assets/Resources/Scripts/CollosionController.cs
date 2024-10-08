﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollosionController : MonoBehaviour {

    public BallBehavior ballMovement;
    public ScoreController scoreController;

    void BounceFromRackett(Collision2D c)
    {
        Vector3 ballPosition = transform.position;
        Vector3 racketPosition = c.gameObject.transform.position;

        float racketHight = c.collider.bounds.size.y;

        float x;
        if (c.gameObject.name == "RacketPlayer1")
        {
            x = 1;
        }
        else
        {
            x = -1; 
        }

        float y = (ballPosition.y - racketPosition.y) / racketHight;
        this.ballMovement.IncreaseHitCounter();
        this.ballMovement.MoveBall(new Vector2(x, y));

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name =="RacketPlayer1" || collision.gameObject.name == "RacketPlayer2")
        {
            BounceFromRackett(collision);
        }
        else if(collision.gameObject.name == "WallLeft")
        {
            scoreController.GoalPlayer2();
            StartCoroutine(ballMovement.StartBall(true));
            
        }
        else if (collision.gameObject.name == "WallRight")
        {
            scoreController.GoalPlayer1();
            StartCoroutine(ballMovement.StartBall(false));
        }
    }
}
