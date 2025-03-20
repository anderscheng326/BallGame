using System.Data;
using UnityEngine;

public class Ball : MonoBehaviour
{
    int health = 20;
    int colcnt = 0;

    float timer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("This is the first script");
        Vector3 position = transform.position;
        position.y = -2;
        transform.position = position;
        Debug.Log("the first game object");

        Vector2 localScale = transform.localScale;
        localScale.x = 2;
        localScale.y = 2;
        transform.localScale = localScale;
        Debug.Log("double the scale of object");

        float rndmag = Random.Range(3, 6);
        float rndangl = Random.Range(0, 360);
        float rnddirx = Mathf.Cos(rndangl);
        float rnddiry = Mathf.Sin(rndangl);

        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
        Debug.Log("Angle = " + rndangl + " Magnitude = " + rndmag + " Direction = " + rnddirx + "," + rnddiry);
        rb2d.AddForce(new Vector2((rndmag * rnddirx),(rndmag * rnddiry)),ForceMode2D.Impulse);

        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = Time.deltaTime;
        //Debug.Log("Timer: " + timer);
        if (timer > 2.0f)
        {
            Debug.Log("-----------------------Time: " + timer);
            timer = 0;
        }

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("BANG - Collisions: "+colcnt);
        health--;
        colcnt++;
        if (health < 0)
        {
            Destroy(gameObject);
            Debug.Log("Ball Destroyed, Game Over!");
        }
    }
}
