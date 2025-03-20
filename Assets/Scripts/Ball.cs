using UnityEngine;

public class Ball : MonoBehaviour
{
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

        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();       
        rb2d.AddForce(new Vector2(2, 2),ForceMode2D.Impulse);

        //int rndmag = Random.Range(3, 6);
        //int rndangl = Random.Range(0, 360); 
        //(Mathf.Cos(rndangl), Mathf.Sin(rndangl)); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 
}
