using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDaube : MonoBehaviour
{
    public GameObject objectToSpawn;
    private float xMin;
    private float xMax;
    private float yMin;
    private float yMax;
    private float zHight;


    public GameObject cubeRH;
    public GameObject cubeLV;

    // Start is called before the first frame update
    void Start()
    {
        yMin = cubeLV.transform.position.z;
        yMax = cubeRH.transform.position.z;
        xMin = cubeLV.transform.position.x;
        xMax = cubeRH.transform.position.x;
        zHight = cubeRH.transform.position.y;
        SpawnObject();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObject()
    {
        Vector3 spawnPos = new Vector3(Random.Range(xMin, xMax),zHight, Random.Range(yMin, yMax));
        Instantiate(objectToSpawn, spawnPos, Quaternion.identity);
    }
}
