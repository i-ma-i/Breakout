using UnityEngine;
using UnityEngine.SceneManagement;

public class Breakout : MonoBehaviour
{
    Ball m_ball;
    float m_deadLine;
    bool m_playing;

    private void Start()
    {
        m_ball = FindObjectOfType<Ball>();
        m_deadLine = FindObjectOfType<Bar>().transform.position.y - 1;
        m_playing = true;
    }

    private void Update()
    {
        if(m_playing == false)
        {
            return;
        }

        if (m_ball.transform.position.y < m_deadLine)
        {
            Destroy(m_ball.gameObject);
            m_playing = false;
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void Exit()
    {
        Application.Quit();
    }
}
