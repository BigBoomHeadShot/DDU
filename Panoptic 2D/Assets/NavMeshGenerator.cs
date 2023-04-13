using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NavMeshPlus;
using UnityEngine.AI;




public class NavMeshGenerator : MonoBehaviour
{
    public NavMeshSurface Surface2D;
    

    // Start is called before the first frame update
    void Start()
    {
        Surface2D = GetComponent<NavMeshSurface>();
        StartCoroutine(GenerateNavmesh());
    }

    private IEnumerator GenerateNavmesh()
    {
        yield return new WaitForSeconds(1);
        Surface2D.UpdateNavMesh(Surface2D.navMeshData);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
