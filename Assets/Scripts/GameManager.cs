using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public Player player;
    public Text scoreText;
    public GameObject PlayButton;
    public GameObject Game;
    public GameObject Over;
    private int score;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        Pause();
    }

    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();

        PlayButton.SetActive(false);
        Game.SetActive(false);
        Over.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for (int i = 0; i < pipes.Length; i++)
            Destroy(pipes[i].gameObject);
        {

        }
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void GameOver()
    {
        Game.SetActive(true);
        Over.SetActive(true);
        PlayButton.SetActive(true);

        Pause();

    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
