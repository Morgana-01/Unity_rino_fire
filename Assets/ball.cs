using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    Rigidbody2D rb;
    public Slider slider;
    public TextMeshProUGUI point_text;
    int points = 0;
    Vector3 startpos;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startpos = transform.position;
    }

    void Update()
    {

    }

    public void FireKlikk()
    {
        float speedMultiplier = 10f; // állíthatod nagyobbra is
        rb.linearVelocity = Vector2.right * slider.value * speedMultiplier;


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "rino")
        {
            points++;
            point_text.text = "Points: " + points;
        }

        if (collision.gameObject.name != "polc")
        {
            transform.position = startpos;
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = 0;
        }
    }
}
