using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    [SerializeField] AudioClip breakSound;



    Level level;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }


    public void BlocksLeft()
    {
     //   int blocks =  GameObject.FindGameObjectsWithTag("block").Length;

      //  print(blocks);
    }

    void Start()
    {
        level = FindObjectOfType<Level>();
        
        

    }

    void Update()
    {
        

    }
}
