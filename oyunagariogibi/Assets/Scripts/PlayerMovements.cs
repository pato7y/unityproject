////using System.Collections;
////using System.Collections.Generic;
////using UnityEngine;

////public class PlayerMovements : MonoBehaviour
////{

////    Actions actions;

////    public float Speed = 5f;
////    // Start is called before the first frame update
////    void Start()
////    {
////        actions = GetComponent<Actions>();
////    }

////    // Update is called once per frame
////    void Update()
////    {
////        float Speed_ = Speed ;
////        Vector2 Direction = Camera.main.ScreenToWorldPoint(Input.mousePosition);
////        transform.position = Vector2.MoveTowards(transform.position, Direction, Speed_ * Time.deltaTime);


////        if (Input.GetKey(KeyCode.W))
////        {
////            //actions.ThrowMass();
////        }
////    }
////}

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class PlayerMovements : MonoBehaviour
//{

//    Actions actions;

//    public float Speed = 5f;
//    // Start is called before the first frame update
//    void Start()
//    {
//        actions = GetComponent<Actions>();
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        float Speed_ = Speed;
//        Vector2 Direction = Camera.main.ScreenToWorldPoint(Input.mousePosition);
//        transform.position = Vector2.MoveTowards(transform.position, Direction, Speed_ * Time.deltaTime);


//        if (Input.GetKey(KeyCode.W))
//        {
//            actions.ThrowMass();
//        }
//    }
//}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{

    Actions actions;

    public bool LockActions = false;
    public float Speed = 5f;
   //  Map map;
    // Start is called before the first frame update
    void Start()
    {
        //map=Map.ins;
        actions = GetComponent<Actions>();
    }

    // Update is called once per frame
    void Update()
    {
        float Speed_ = Speed ;
        Vector2 Direction = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.MoveTowards(transform.position, Direction, Speed_ * Time.deltaTime);
        //Direction.x = Mathf.Clamp(Direction.x, map.MapLimits.x * -1 / 2, map.MapLimits.x * 1 / 2);
        //Direction.y = Mathf.Clamp(Direction.y, map.MapLimits.y * -1 / 2, map.MapLimits.y * 1 / 2);


        if (LockActions)
        {
            return;
        }

        if (Input.GetKey(KeyCode.W))
        {
            actions.ThrowMass();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // jump
            actions.Split();
        }
    }
}

