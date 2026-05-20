using UnityEngine;
using Unity.VisualScripting;

public class Ball : MonoBehaviour
{
    [SerializeField] private float speedX;
    [SerializeField] private float speedY;
    private float currentSpeedX;
    private float currentSpeedY;
    private int pontos;

    void Start()
    {
        currentSpeedX = speedX;
        currentSpeedY = speedY;
    }

    void Update()
    {
        transform.Translate(currentSpeedX * Time.deltaTime, currentSpeedY * Time.deltaTime, 0.0f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "WallX" || collision.gameObject.tag == "Player")
        {
            currentSpeedX *= -1;
        }
        if(collision.gameObject.tag == "WallY" || collision.gameObject.tag == "Player")
        {
            currentSpeedY *= -1;
        }
        if (collision.gameObject.tag == "Blocks")
        {
            Destroy(collision.gameObject);
            currentSpeedX *= -1;
            currentSpeedY *= -1;
            pontos++;
        }
        print("Pontuação: " + pontos);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Center")
        {
            currentSpeedX = 0.0f;
        }
        else if (collision.tag == "Left")
        {
            currentSpeedX = speedX;
        }
        else if(collision.tag == "Right")
        {
            currentSpeedX = -speedX;
        }
        currentSpeedY = -speedY;
    }
}
