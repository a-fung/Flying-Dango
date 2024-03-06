using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float offScreen = -20.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = transform.position + Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < offScreen)
        {
            Destroy(this.gameObject);
        }
    }
}
