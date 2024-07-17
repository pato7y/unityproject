using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Map : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}
    public static Map ins;
    public Color MapLimits_Color;
    private void Awake()
    {
        if (ins == null)
        {
            ins = this;
        }
    }

        public Vector2 MapLimits;

    private void OnDrawGizmos()
    {
        Gizmos.color = MapLimits_Color;
        Gizmos.DrawWireCube(transform.position, MapLimits);
    }
}

