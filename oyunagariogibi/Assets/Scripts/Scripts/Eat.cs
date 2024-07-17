//using UnityEngine;
//using UnityEngine.UI;
//using System.Collections;

//public class Eat : MonoBehaviour
//{
//    public string Tag;
//    public Text Letters;
//    public float Increase;

//    int Score = 0;

//    void OnTriggerEnter(Collider other)
//    {
//        if (other.gameObject.tag == Tag)
//        {
//            transform.localScale += new Vector3(Increase, Increase, Increase);
//            Destroy(other.gameObject);

//            Score += 1;
//            Letters.text = "SCORE: " + Score;
//        }
//    }
//}

using UnityEngine;
using UnityEngine.UI;

public class Eat : MonoBehaviour
{
    public string Tag;
    public Text Letters;
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
            Letters.text = "SCORE: " + Score;
        }
    }
}
