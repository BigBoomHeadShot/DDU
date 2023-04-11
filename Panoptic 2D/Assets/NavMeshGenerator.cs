using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NavMeshPlus;
using UnityEngine.AI;



public class NavMeshGenerator : MonoBehaviour
{
    public  
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("GenerateNavmesh");
    }

    private IEnumerator GenerateNavmesh()
    {
        yield return new WaitForSeconds(1);
        GenerateNavmesh();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
