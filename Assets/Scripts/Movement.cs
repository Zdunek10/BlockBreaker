using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] float ScreenWidthUnit;

    private float xMin = 1f, xMax = 15f;

    void Update()
    {

        float mouPosition = (Input.mousePosition.x / Screen.width * ScreenWidthUnit);

        Vector2 paddlePosition = new Vector2(mouPosition, transform.position.y);

      //Vector2 paddlePosition = Vector2.zero;
      //paddlePosition.x = Input.GetAxis("Horizontal");


        //Ograniczenie przesuwania sie paletki o xMin (lewy kraniec ekranu), xMax (prawy kraniec ekranu)
        paddlePosition.x = Mathf.Clamp(paddlePosition.x, xMin, xMax);


        transform.position = paddlePosition;


        //  ArrowsMove();
    }

    public void ArrowsMove()
    {
        Vector2 move = Vector2.zero;
        move.x = Input.GetAxis("Horizontal");

  
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            Debug.Log("Arrow Right Clicked");
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            Debug.Log("Arrow Left Clicked");
        }
    }
}
