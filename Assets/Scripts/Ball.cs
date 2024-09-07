using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5;
    Rigidbody2D m_rigidBody;

    private void Start()
    {
        m_rigidBody = GetComponent<Rigidbody2D>();
        m_rigidBody.gravityScale = 0;
        m_rigidBody.AddForce(new Vector2(speed, speed), ForceMode2D.Impulse);
        m_rigidBody.velocity = new Vector2(speed, speed);
    }
}
