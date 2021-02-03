using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Randomizer : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> prefabsToSpawn;

    private int randomIndex;

    private void Awake()
    {
        //prefabsToSpawn = new List<GameObject>();
    }

    private void Start()
    {
        SpawnGameObjects();
    }

    public void SpawnGameObjects()
    {
        int randomIndex = Random.Range(0, prefabsToSpawn.Count);
        GameObject currentPrefab = prefabsToSpawn[randomIndex];
        prefabsToSpawn.RemoveAt(randomIndex);
        Instantiate(currentPrefab);

        //currentPrefab.transform.parent = GameObject.Find("Scramble Screen").transform;
    }
}