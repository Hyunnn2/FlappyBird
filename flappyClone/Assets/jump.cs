using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpPower;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //0Àº ¿ÞÂÊ ¹öÆ°
        {
            GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * jumpPower; //(0,3)
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(score.sc > score.bestsc)
        {
            score.bestsc = score.sc;
        }
        SceneManager.LoadScene("gameoverScene");
    }
}
