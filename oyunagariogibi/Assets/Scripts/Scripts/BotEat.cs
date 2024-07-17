//using UnityEngine;
//using UnityEngine.UI;
//using System.Collections;

//public class BotEat : MonoBehaviour
//{
//    public string Tag;
//    public Text ScoreText;
//    public float Increase;

//    int Score = 0;

//    void OnTriggerEnter(Collider other)
//    {
//        if (other.gameObject.tag == Tag)
//        {
//            transform.localScale += new Vector3(Increase, Increase, Increase);
//            Destroy(other.gameObject);

//            Score += 1;
//            ScoreText.text = "bot: " + Score;
//        }
//    }
//}

////this code is to test if the project works or the pushes for github via git is succesfful

using UnityEngine;
using UnityEngine.UI;

public class BotEat : MonoBehaviour
{
    public string Tag;
    public Text ScoreText;
    public float Increase;

    // Public property to access the score
    public int Score { get; set; }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == Tag)
        {
            transform.localScale += new Vector3(Increase, Increase, Increase);
            Destroy(other.gameObject);

            Score += 1;
            ScoreText.text = "bot: " + Score;
        }
    }
}
