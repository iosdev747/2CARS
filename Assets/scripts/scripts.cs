using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scripts : MonoBehaviour
{
    public static float speed;
    void Start()
    {
        speed = PlayerPrefs.GetFloat("speed");
    }
    void Update()
    {
        speed += Time.deltaTime/10 ;
        PlayerPrefs.SetFloat("speed", speed);
        this.transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
    private void gameover()
    {
        Debug.Log("gameover");
        SceneManager.LoadScene("game");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (((this.gameObject.tag == "BlueSquare" || this.gameObject.tag == "RedSquare") && (collision.gameObject.tag == "left" || collision.gameObject.tag == "right")) || ((this.gameObject.tag == "BlueCircle" || this.gameObject.tag == "RedCircle") && collision.gameObject.tag == "Destroyer"))
        {
            gameover();
        }
        if ((this.gameObject.tag == "BlueCircle" || this.gameObject.tag == "RedCircle") && (collision.gameObject.tag == "left" || collision.gameObject.tag=="right"))
        {
            GameManager.points();
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "Destroyer")
        {
            Destroy(this.gameObject);
        }
    }
}