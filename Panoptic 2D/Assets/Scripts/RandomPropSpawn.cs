using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPropSpawn : MonoBehaviour
{
    [SerializeField] GameObject[] proplist;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(proplist[Random.Range(0,proplist.Length)], transform);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
