using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizePreserver : MonoBehaviour
{
    // Start is called before the first frame update
        public float FixeScale = 1;
        public GameObject parent;

        // Update is called once per frame
        void Update()
        {
            transform.localScale = new Vector3(FixeScale / parent.transform.localScale.x, FixeScale / parent.transform.localScale.y, FixeScale / parent.transform.localScale.z);

        }
}
