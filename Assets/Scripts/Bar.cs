using UnityEngine;

public class Bar : MonoBehaviour
{
    public float speed = 5;

    Rigidbody2D m_rigidBody;

    private void Start()
    {
        m_rigidBody = GetComponent<Rigidbody2D>();

        m_rigidBody.mass = 1000;
        m_rigidBody.gravityScale = 0;
        m_rigidBody.constraints = RigidbodyConstraints2D.FreezePositionY;
        m_rigidBody.freezeRotation = true;
    }

    private void Update()
    {
        m_rigidBody.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, 0);
    }
}
