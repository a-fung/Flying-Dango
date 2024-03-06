using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangoScript : MonoBehaviour
{
    public Rigidbody2D dangoRigidBody;
    public float flapStrength = 100.0f;
    public LogicManagerScript logic;
    public bool isAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isAlive)
        {
            if (Input.GetKeyDown(KeyCode.V) || Input.GetKeyDown(KeyCode.Space))
            {
                this.dangoRigidBody.velocity = Vector2.up * flapStrength;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        isAlive = false;
    }
}
