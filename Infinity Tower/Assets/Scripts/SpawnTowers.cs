using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Random = UnityEngine.Random;

public class SpawnTowers : MonoBehaviour {
    public GameObject tower;
    public GameObject towerHolder;
    
    public int numberOfTowers;
    
    public List<Transform> spawnLocations;
    
	// Use this for initialization
	void Start () {       
       InvokeRepeating("CreateNewTower", 0, 8.0f);
	}
	
    void CreateNewTower(){
            int range = Random.Range(0, spawnLocations.Count);
            GameObject obj = Instantiate(tower) as GameObject;
            obj.transform.SetParent(towerHolder.transform);
            obj.transform.position = spawnLocations[range].position;
            obj.SetActive(true);
    }
}
