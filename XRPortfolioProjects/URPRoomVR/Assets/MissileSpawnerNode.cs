using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileSpawnerNode : MonoBehaviour
{
    public GameObject[] missilePrefabs;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnMissilesTest());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SpawnMissilesTest()
    {
        while (true)
        {
            yield return new WaitForSeconds(2); //wait 2 seconds
                                                //do thing

            print(this.gameObject.transform.position);
            Instantiate(missilePrefabs[0], this.gameObject.transform.position, this.gameObject.transform.rotation);
        }
    }

}
