using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject enemyPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemyPrefab, new Vector3(14, -3, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
