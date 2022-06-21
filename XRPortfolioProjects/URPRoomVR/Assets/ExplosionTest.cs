using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionTest : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject explosion;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter(Collision hit)
    {
        //if (hit.impactForceSum.magnitude > 10) {
        Debug.Log("yay");
        Instantiate(explosion, this.transform.position + Vector3.up*0.5f, this.transform.rotation);
        Destroy(hit.gameObject);
        //}
    }

    void OnTriggerEnter(Collision hit)
    {
        //if (hit.impactForceSum.magnitude > 10) {
        Debug.Log("nay");
        //}
    }

}
