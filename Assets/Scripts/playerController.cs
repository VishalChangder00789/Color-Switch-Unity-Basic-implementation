using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{
    public float jumpForce = 10.0f;
    public Rigidbody2D rigidbody;
    public Text textsetter;

    lastScoreSETTER setter;

    public Text Scoresetter;
    public int score=0;

    public Color currentColor;

    public Color PURPLE;
    public Color YELLOW;
    public Color BLUE;
    public Color RED;

    // Update is called once per frame
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        currentColor = PURPLE;
        transform.GetComponent<SpriteRenderer>().color = currentColor;
        score = 0;
    }
    void Update()
    {
        if (Input.touchCount>0)
        {
            rigidbody.velocity = Vector2.up * jumpForce;
        }



        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.velocity = Vector2.up * jumpForce;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag== "destroyer")
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(2);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "purple" && transform.GetComponent<SpriteRenderer>().color != PURPLE)
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(2);
        }

        if (collision.tag == "red" && transform.GetComponent<SpriteRenderer>().color != RED)
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(2);
            //destroy it and show the ui with score
        }
        if (collision.tag == "yellow" && transform.GetComponent<SpriteRenderer>().color != YELLOW)
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(2);
            setter.text.text = score.ToString();
            //destroy it and show the ui with score
        }
        if (collision.tag == "blue" && transform.GetComponent<SpriteRenderer>().color != BLUE)
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(2);


            //destroy it and show the ui with score
        }

        if (collision.tag == "colorChanger")
        {
            transform.GetComponent<SpriteRenderer>().color = collision.GetComponent<SpriteRenderer>().color;
            Destroy(collision.gameObject);
        }

        if (collision.tag == "star")
        {
            score = score + 1;
            string SCORE1=score.ToString();
            textsetter.text = SCORE1;
            Destroy(collision.gameObject);
        }
        
    }
}
