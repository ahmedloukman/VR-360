using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    public float speed = 0.5f;
    private string lou;
    private bool moh;
   

    // Update is called once per frame
    void Update()
    {
        if (moh)
        {
            if (lou.ToUpper().Equals("Y"))
            {
                transform.Rotate(Vector3.up * speed);
            }
            if (lou.ToUpper().Equals("Z"))
            {
                transform.Rotate(Vector3.down * speed);
            }
            if (lou.ToUpper().Equals("X"))
            {
                transform.Rotate(Vector3.right * speed);
            }
            if (lou.ToUpper().Equals("W"))
            {
                transform.Rotate(Vector3.left * speed);
            }
        }
        
    }
    public void RotateButtons (string lou)
    {
        this.lou = lou;
        moh = true;
    }
    public void StopRotation()
    {
        moh = false;
    }
}
