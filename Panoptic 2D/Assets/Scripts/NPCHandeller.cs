using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class NPCHandeller : MonoBehaviour
{
    int numberOfNPCs;
    public TextMeshProUGUI npcTextCounter;

    GameObject[] NPCs;

    GameObject currentSpawnPoint;

    List<GameObject> newSpawnPoints = new List<GameObject>();

    GameObject[] spawnPoints;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("spawnPoint");
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            newSpawnPoints.Add(spawnPoints[i]);
        }

        //npcTextCounter = gameObject.GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        NPCs = GameObject.FindGameObjectsWithTag("NPC");
        numberOfNPCs = NPCs.Length;
        display();
    }

    void display()
    {
        npcTextCounter.text = "NPCs: " + numberOfNPCs;
    }
}
