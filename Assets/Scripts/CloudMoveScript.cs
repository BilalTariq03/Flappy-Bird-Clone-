using UnityEngine;

public class CloudMoveScript : MonoBehaviour
{
    public float maxSpeed;
    public float deadZone = -60f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * maxSpeed) * Time.deltaTime;
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);   
        }
    }
}
