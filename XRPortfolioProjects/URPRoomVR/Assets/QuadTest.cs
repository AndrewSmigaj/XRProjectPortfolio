using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadTest : MonoBehaviour
{
    // Start is called before the first frame update


    void Start()
    {
        //test to initiate quad
        Vector3[] vertices = new Vector3[5]
        {
            new Vector3(0, 0, 0),
            new Vector3(1, 0, 0),
            new Vector3(0, 1, 0),
            new Vector3(1, 1, 0),
            new Vector3(1, -1, 0)
        };

        var oldQuad = this.gameObject.GetComponent<MeshFilter>();
        oldQuad.mesh.vertices = vertices;

        int[] tris = new int[9]
        {
            // lower left triangle
            0, 2, 1,
            // upper right triangle
            2, 3, 1,
            0,2,4 
        };
        oldQuad.mesh.triangles = tris;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
