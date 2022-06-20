using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector3 testAxis;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update ()
	{
    	transform.Rotate ( 25 * Time.deltaTime * testAxis); //rotates 50 degrees per second around z axis
	}
}
