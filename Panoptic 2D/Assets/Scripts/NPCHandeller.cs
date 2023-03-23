using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class NPCHandeller : MonoBehaviour
{
    int numberOfNPCs;
    int index;
    float timer;
    public float delay = 1f;

    public TextMeshProUGUI npcTextCounter;

    GameObject[] NPCs;

    GameObject npcPrefab;

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
        spawnNpc();
    }

    void display()
    {
        npcTextCounter.text = "NPCs: " + numberOfNPCs;
    }

    void spawnNpc()
    {
        timer += Time.deltaTime;
        if (numberOfNPCs <= 10 && timer > delay)
        {
            index = Random.Range(0, spawnPoints.Length);
            currentSpawnPoint = spawnPoints[index];
            Instantiate(npcPrefab, currentSpawnPoint.transform.position, currentSpawnPoint.transform.rotation);
        }
    }
}
