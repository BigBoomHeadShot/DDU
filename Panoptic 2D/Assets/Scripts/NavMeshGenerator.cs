using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NavMeshPlus;
using UnityEngine.AI;




public class NavMeshGenerator : MonoBehaviour
{

    

    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(GenerateNavmesh());
    }

    private IEnumerator GenerateNavmesh()
    {
        yield return new WaitForSeconds(0.2f);
        AstarPath.active.Scan();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
