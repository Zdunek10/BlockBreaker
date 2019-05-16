using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField] Movement paddle1;
    [SerializeField] float xPush = 2f;
    [SerializeField] float yPush = 15f;
    [SerializeField] AudioClip[] ballSounds;

    
    Vector2 paddleToBallVector;
    //  int score;

    bool hasStarted = false;

    AudioSource myAudioSource;


    private float xMin = 1f, xMax = 15f;

    void Start()
    {

        paddleToBallVector = transform.position - paddle1.transform.position;
        //   score = LoseCollider.playerScore;
        //   Debug.Log(LoseCollider.playerScore);

        Debug.Log(paddle1.transform.position);
        Debug.Log(transform.position);

        myAudioSource = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {



        if (!hasStarted)
        {
          LockBallToPaddle();
          LaunchOnMouseClick();
        }
       

        //  Debug.Log("paddlePos" + paddlePos);
        //  Debug.Log("paddleToBallVector" + paddleToBallVector);
        //    Debug.Log(paddle1.transform.position);

    }


    private void ograniczeniePilki()
    {

        Vector2 ballPosition = new Vector2(transform.position.x, transform.position.y);

        ballPosition.x = Mathf.Clamp(transform.position.x, xMin, xMax);


    }


    private void LockBallToPaddle()
    {
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlePos + paddleToBallVector;
    }


    private void LaunchOnMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
            //zero jako lewy przycisk klawisza myszy
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(xPush, yPush);
            hasStarted = true;

        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (hasStarted)
        {

            AudioClip clip = ballSounds[Random.Range(0, ballSounds.Length)];


            myAudioSource.PlayOneShot(clip);

        }
     
    }

}
