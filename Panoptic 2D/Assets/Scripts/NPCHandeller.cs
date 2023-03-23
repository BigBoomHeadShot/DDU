using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class NPCHandeller : MonoBehaviour
{
    int numberOfNPCs;
    int index;
    float timer;
    public float delay = 2f;
    public int maxNPCs = 10;

    public TextMeshProUGUI npcTextCounter;

    GameObject[] NPCs;

    public GameObject npcPrefab;

    GameObject currentSpawnPoint;

    GameObject[] spawnPoints;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("spawnPoint");

    }

    // Update is called once per frame
    void Update()
    {
        NPCs = GameObject.FindGameObjectsWithTag("NPC");
        numberOfNPCs = NPCs.Length;
        display();
        spawnNPC();



    }

    void display()
    {
        npcTextCounter.text = "NPCs: " + numberOfNPCs;
    }


    void spawnNPC()
    {

        
        timer += Time.deltaTime;
        if (numberOfNPCs < maxNPCs)
        {
            if (timer < delay)
            {
                timer = 0;
                index = Random.Range(0, spawnPoints.Length);
                currentSpawnPoint = spawnPoints[index];
                Instantiate(npcPrefab, currentSpawnPoint.transform.position, currentSpawnPoint.transform.rotation);
            }
        }
        
    }

}
