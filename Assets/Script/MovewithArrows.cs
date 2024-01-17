using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovewithArrows : MonoBehaviour
{
    public float Mspeed = 0.5f;
    private float dirX, dirZ;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis("Horizantal") * Mspeed;
        dirZ = Input.GetAxis("Vertical") * Mspeed;
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector3(dirX, rb.velocity.y, dirZ);
    }
}
