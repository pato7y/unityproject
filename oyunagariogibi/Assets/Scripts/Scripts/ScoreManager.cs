//using UnityEngine;

//public class ScoreManager : MonoBehaviour
//{
//    public Eat playerEat;
//    public BotEat botEat;

//    void Start()
//    {
//        playerEat = FindObjectOfType<Eat>();
//        botEat = FindObjectOfType<BotEat>();
//    }

//    void Update()
//    {
//        if (playerEat != null && botEat != null)
//        {
//            int playerScore = playerEat.Score;
//            int botScore = botEat.Score;

//            if (playerScore > botScore)
//            {
//                // Player absorbs bot's score
//                playerEat.Score += botScore;
//                botEat.Score = 0; // Optionally reset bot's score to 0
//                botEat.ScoreText.text = "bot: " + botEat.Score; // Update bot's score text
//            }
//            else if (botScore > playerScore)
//            {
//                // Game over logic when bot's score is higher than player's score
//                Debug.Log("Game Over - Bot defeated player!");
//                // Implement game over UI, reset scene, etc.
//            }
//            // If scores are equal, continue playing without any action
//            else
//            {
//                Debug.Log("Scores are equal. Continue playing.");
//                // Continue playing logic, no action needed in this case
//            }
//        }
//    }
//}
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public Eat playerEat;
    public BotEat botEat;

    void Start()
    {
        playerEat = FindObjectOfType<Eat>();
        botEat = FindObjectOfType<BotEat>();
    }

    void Update()
    {
        // Example of periodic score comparison (optional)
        // You can remove this if you only want collision-based score updates
        if (playerEat != null && botEat != null)
        {
            int playerScore = playerEat.Score;
            int botScore = botEat.Score;

            if (playerScore > botScore)
            {
                // Player absorbs bot's score
                playerEat.Score += botScore;
                botEat.Score = 0; // Optionally reset bot's score to 0
                botEat.ScoreText.text = "bot: " + botEat.Score; // Update bot's score text
            }
            else if (botScore > playerScore)
            {
                // Game over logic when bot's score is higher than player's score
                Debug.Log("Game Over - Bot defeated player!");
                // Implement game over UI, reset scene, etc.
            }
            // If scores are equal, continue playing without any action
            else
            {
                Debug.Log("Scores are equal. Continue playing.");
                // Continue playing logic, no action needed in this case
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check collision between player and bot
        if (collision.gameObject.CompareTag("Player") && collision.gameObject.CompareTag("Bot"))
        {
            // Access the Eat and BotEat scripts on the colliding objects
            Eat player = collision.gameObject.GetComponent<Eat>();
            BotEat bot = collision.gameObject.GetComponent<BotEat>();

            if (player != null && bot != null)
            {
                int playerScore = player.Score;
                int botScore = bot.Score;

                if (playerScore > botScore)
                {
                    // Player absorbs bot's score
                    player.Score += botScore;
                    bot.Score = 0; // Optionally reset bot's score to 0
                    bot.ScoreText.text = "bot: " + bot.Score; // Update bot's score text
                }
                else if (botScore > playerScore)
                {
                    // Game over logic when bot's score is higher than player's score
                    Debug.Log("Game Over - Bot defeated player!");
                    // Implement game over UI, reset scene, etc.
                }
                // If scores are equal, continue playing without any action
                else
                {
                    Debug.Log("Scores are equal. Continue playing.");
                    // Continue playing logic, no action needed in this case
                }
            }
        }
    }
}
