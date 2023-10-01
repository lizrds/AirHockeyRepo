using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Ball : MonoBehaviour
{
    public TMP_Text PlayerPointsText;
    public TMP_Text EnemyPointsText;
    int PlayerPoints = 0;
    int EnemyPoints = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        PlayerPointsText.text = PlayerPoints.ToString();
        EnemyPointsText.text = EnemyPoints.ToString();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("PlayerGoal"))
        {
            transform.position = new Vector3(6, -1, 0);
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            EnemyPoints += 1;

        }
        if (collision.gameObject.name.Contains("EnemyGoal"))
        {
            transform.position = new Vector3(6, -1, 0);
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            PlayerPoints += 1;

        }
    }

}
