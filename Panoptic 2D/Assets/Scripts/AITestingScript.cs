using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AITestingScript : MonoBehaviour
{




    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(upDateScan());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator upDateScan()
    {

        yield return new WaitForSeconds(0.5f);
        AstarPath.active.Scan();
    }
}
