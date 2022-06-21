using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{

    public float prototypeDownSpeed = 0;
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.down * prototypeDownSpeed *Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {

        Instantiate(explosion, this.transform.position, this.transform.rotation);
        Debug.Log("Collided");
    }

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(explosion, this.transform.position, this.transform.rotation);
        Debug.Log("Triggered");
    }
}
