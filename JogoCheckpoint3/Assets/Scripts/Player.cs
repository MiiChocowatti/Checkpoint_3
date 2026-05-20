using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    private float x;
    void Update()
    {
        x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(x, 0.0f, 0.0f);
    }
}
