using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2.0f;
    private float timer = 0.0f;
    private float offset = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 0.0f)
        {
            this.SpawnPipe();
            this.timer -= this.spawnRate;
        }

        this.timer += Time.deltaTime;
    }

    void SpawnPipe()
    {
        float highestPoint = transform.position.y + offset;
        float lowestPoint = transform.position.y - offset;
        Instantiate(
            pipe, 
            new Vector3(transform.position.x, Random.Range(highestPoint, lowestPoint), transform.position.z),
            transform.rotation);
    }
}
