using UnityEngine;

public class BotMovement : MonoBehaviour
{
    public float speed = 2f;
    public float changeDirectionInterval = 2f;

    private Vector3 targetPosition;
    private float timeSinceLastChange = 0f;

    void Start()
    {
        ChangeDirection();
    }

    void Update()
    {
        timeSinceLastChange += Time.deltaTime;

        if (timeSinceLastChange > changeDirectionInterval)
        {
            ChangeDirection();
            timeSinceLastChange = 0f;
        }

        MoveTowardsTarget();
    }

    void ChangeDirection()
    {
        int x = Random.Range(0, Camera.main.pixelWidth);
        int y = Random.Range(0, Camera.main.pixelHeight);

        targetPosition = Camera.main.ScreenToWorldPoint(new Vector3(x, y, 0));
        targetPosition.z = transform.position.z; // Keep the same z position
    }

    void MoveTowardsTarget()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }
}
