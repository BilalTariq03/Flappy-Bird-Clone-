using UnityEngine;

public class CloudSpawnerScript : MonoBehaviour
{
    public GameObject cloud;
    public float spawnRate = 7;
    public float timer = 0;
    public float heightOffset = 17;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnCloud();
            timer = 0;
        }
    }

    public void spawnCloud()
    {
        float maxHeight = transform.position.y + heightOffset;
        float minHeight = transform.position.y - heightOffset;

        Instantiate(cloud, new Vector3(transform.position.x, Random.Range(minHeight, maxHeight), 0), transform.rotation);
    }
}
