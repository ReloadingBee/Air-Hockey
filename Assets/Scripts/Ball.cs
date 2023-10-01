using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{
    int enemyScore = 0;
    int playerScore = 0;
    public TMP_Text EnemyScoreText;
    public TMP_Text PlayerScoreText;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name.Contains("Goal"))
        {
            transform.position = Vector3.zero;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }

        if (other.gameObject.name.Contains("Enemy Goal"))
        {
                enemyScore += 1;
                EnemyScoreText.text = enemyScore.ToString();
        }
        if (other.gameObject.name.Contains("Player Goal"))
        {
                playerScore += 1;
                PlayerScoreText.text = playerScore.ToString();
        }
    }
}
