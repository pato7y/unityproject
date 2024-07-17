////////using System.Collections;
////////using System.Collections.Generic;
////////using UnityEngine;
////////using UnityEngine.Rendering;
////////using UnityEngine.UI;

////////public class PlayerScore : MonoBehaviour
////////{
////////    // Start is called before the first frame update
////////    //void Start()
////////    //{

////////    //}

////////    //// Update is called once per frame
////////    //void Update()
////////    //{

////////    //}
////////    private void Start()
////////    {
////////        InvokeRepeating("UpdateScore",1,1);
////////    }
////////    public Text Score;
////////    public float ScoreEditor;


////////    void UpdateScore()
////////    {
////////        float _score = 0f;
////////        GameObject[] player = GameObject.FindGameObjectsWithTag("Player");
////////        for (int i = 0; i < player.Length; i++)
////////        {
////////            _score += player[i].transform.localScale.x;
////////        }
////////        Score.text=_score.ToString("f0");
////////    }
////////}
//////using UnityEngine;
//////using UnityEngine.UI;

//////public class PlayerScore : MonoBehaviour
//////{
//////    public Text ScoreText;

//////    void Start()
//////    {
//////        UpdateScore();
//////    }

//////    public void UpdateScore()
//////    {
//////        float score = 0f;
//////        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
//////        for (int i = 0; i < players.Length; i++)
//////        {
//////            score += players[i].transform.localScale.x;
//////        }
//////        ScoreText.text = score.ToString("f0");
//////    }
//////}
////using UnityEngine;
////using UnityEngine.UI;

////public class PlayerScore : MonoBehaviour
////{
////    public Text ScoreText;

////    void Start()
////    {
////        UpdateScore();
////    }

////    public void UpdateScore()
////    {
////        float score = 0f;
////        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
////        for (int i = 0; i < players.Length; i++)
////        {
////            score += players[i].transform.localScale.x;
////        }
////        ScoreText.text = score.ToString("f0");
////    }
////}
////using UnityEngine;
////using UnityEngine.UI;

////public class PlayerScore : MonoBehaviour
////{
////    public Text ScoreText;

////    void Start()
////    {
////        UpdateScore();
////    }

////    public void UpdateScore()
////    {
////        float _score = 0f;
////        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
////        for (int i = 0; i < players.Length; i++)
////        {
////            _score += players[i].transform.localScale.x;
////        }
////        ScoreText.text = _score.ToString("f0");
////    }
////}

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.Rendering;
//using UnityEngine.UI;

//public class PlayerScore : MonoBehaviour
//{
//    // Start is called before the first frame update
//    //void Start()
//    //{

//    //}

//    //// Update is called once per frame
//    //void Update()
//    //{

//    //}
//    private void Start()
//    {
//        InvokeRepeating("UpdateScore", 1, 1);
//    }

//    public Text Score;
//    public float ScoreEditor;

//    void UpdateScore()
//    {
//        float _score = 0f;
//        GameObject[] player = GameObject.FindGameObjectsWithTag("Player");
//        for (int i = 0; i < player.Length; i++)
//        {
//            _score += player[i].transform.localScale.x;
//        }
//        Score.text = _score.ToString("f0");
//    }
//}
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public Text Score;
    public float ScoreEditor = 1000;

    void UpdateScore()
    {
        // get all players in the scene
        GameObject[] player = GameObject.FindGameObjectsWithTag("Player");

        // collect the scores
        float _score = 0f;

        for (int i = 0; i < player.Length; i++)
        {
            _score += player[i].transform.localScale.x * ScoreEditor;
        }

        // Update UI
        Score.text = _score.ToString("f0");
    }
}
