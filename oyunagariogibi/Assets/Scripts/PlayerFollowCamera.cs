



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollowCamera : MonoBehaviour
{
    public Transform Player; // Reference to the player
    public Vector3 Offset;
    private Vector3 change;
    public float Speed = 0.4f;
    public float MaxZoom = 4f;
    public float MinZoom = 1.5f;
    public float ZoomController = 1.8f;
    public float ZoomSpeed = 0.6f;

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
