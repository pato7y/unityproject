



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollowCamera : MonoBehaviour
{
    public Transform Player; // Reference to the player
    public Vector3 Offset;
    private Vector3 change;
    public float Speed = 1f;
    public float MaxZoom = 6f;
    public float MinZoom = 2f;
    public float ZoomController = 2f;
    public float ZoomSpeed = 1f;

    private Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        // Move camera to follow the player
        Move();
        // Adjust the zoom
        Zoom();
    }

    void Zoom()
    {
        cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, GetZoom(), ZoomSpeed * Time.deltaTime);
        cam.orthographicSize = Mathf.Clamp(cam.orthographicSize, MinZoom, MaxZoom);
    }

    float GetZoom()
    {
        // Adjust the zoom level based on the player's size or other criteria
        return Player.localScale.x / ZoomController;
    }

    void Move()
    {
        if (Player != null)
        {
            Vector3 targetPosition = Player.position + Offset;
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref change, Speed);
        }
    }
}
