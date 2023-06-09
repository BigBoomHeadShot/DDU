using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class NPCHandeller : MonoBehaviour
{
    int numberOfNPCs;
    int lastNumNPC;
    int index;

    float timer;
    public float delay = 2f;
    public int maxNpcs = 60;
    public int currentMaxNpcs = 20;

    public int startNpcs = 10;

    public TextMeshProUGUI npcTextCounter;

    GameObject[] NPCs;
    GameObject currentNPC;
    public GameObject npcPrefab;
    public GameObject hiderPrefab;
    public GameObject ammoBox;
    GameObject currentSpawnPoint;
    GameObject[] spawnPoints;
    [SerializeField] TextMeshProUGUI BulletText;
    [SerializeField] GameObject holsterObject;
    [SerializeField] HolsterScript holster;
    // Start is called before the first frame update
    void Start()
    {

        spawnPoints = GameObject.FindGameObjectsWithTag("spawnPoint");
        beginningSpawns();
        spawnHider();
        StartCoroutine(ammoSpawn());
        StartCoroutine(findHolster());
    }
    IEnumerator findHolster()
    {
        yield return new WaitForSeconds(0.5f);
        holsterObject = GameObject.FindWithTag("Player");
        holster = holsterObject.GetComponentInChildren<HolsterScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (BulletText != null && holster != null)
        {
            BulletText.text = "Bullets " + holster.ammo;
        }

        NPCs = GameObject.FindGameObjectsWithTag("NPC");
        numberOfNPCs = NPCs.Length;
        display();
        delayFunction();
        if (numberOfNPCs < lastNumNPC && currentMaxNpcs < maxNpcs)
        {
            currentMaxNpcs += 1;
        }
        
    }

    private void LateUpdate()
    {
        lastNumNPC = numberOfNPCs;
    }

    void display()
    {
        npcTextCounter.text = "NPCs: " + numberOfNPCs;
    }
    void spawnHider()
    {
        index = Random.Range(0, spawnPoints.Length);
        currentSpawnPoint = spawnPoints[index];
        Instantiate(hiderPrefab, currentSpawnPoint.transform.position, currentSpawnPoint.transform.rotation);
    }

    void delayFunction()
    {
        float delay = 1;
        timer += Time.deltaTime;
        if (timer > delay)
        {
            spawnNPC();
        }
    }

    void spawnNPC()
    {
        if (numberOfNPCs < currentMaxNpcs)
        {
            timer = 0;
            index = Random.Range(0, spawnPoints.Length);
            currentSpawnPoint = spawnPoints[index];
            Instantiate(npcPrefab, currentSpawnPoint.transform.position, currentSpawnPoint.transform.rotation);


        }
    }

    void beginningSpawns()
    {
        for (int i = 0; i < startNpcs; i++)
        {
            spawnNPC();
        }
        
    }

    IEnumerator ammoSpawn()
    {
        while (true)
        {

            yield return new WaitForSeconds(20);
            index = Random.Range(0, spawnPoints.Length);
            currentNPC = NPCs[index];
            Instantiate(ammoBox, currentNPC.transform.position, currentNPC.transform.rotation);
            yield return new WaitForSeconds(1);
            index = Random.Range(0, spawnPoints.Length);
            currentNPC = NPCs[index];
            Instantiate(ammoBox, currentNPC.transform.position, currentNPC.transform.rotation);

        }
    }
}
