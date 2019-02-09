using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    //initX and initY used for instantiating the enemy objects
    public float initX;
    public float initY;

    public GameObject enemyPrefab1;
    public GameObject enemyPrefab2;
    public GameObject enemyPrefab3;

    //Enemy Dictionary, used to store the enemies 
    //each list represents a col of enemies 
    // 
    private Dictionary<int, List<GameObject>> enemyDictionary = new Dictionary<int, List<GameObject>>();


    private void Awake()
    {

        
    }
    // Start is called before the first frame update
    void Start()
    {
        initEnemyDict();
        instantiateEnemyDict();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /* Initiates the enemy dictionary
     * creates a dictionary with 11 keys (representing the 11 cols of enemies)
     * each col has 5 enemies with in 
     */
    private void initEnemyDict()
    {
        for(int i =0; i<11; i++)
        {
            //creates a new List and adds the enemy prefabs to the list 
            enemyDictionary[i] = new List<GameObject>();
            enemyDictionary[i].Add(enemyPrefab3);
            enemyDictionary[i].Add(enemyPrefab2);
            enemyDictionary[i].Add(enemyPrefab2);
            enemyDictionary[i].Add(enemyPrefab1);
            enemyDictionary[i].Add(enemyPrefab1);

        }

    }

    /* instantiates the Enemy objects 
     * 
     */
    private void instantiateEnemyDict()
    {
        float startingX = initX;
        for(int i=0; i<11; i++ )
        {
            float startingY = initY;
            for(int e=0; e<5; e++)
            {
                Instantiate(enemyDictionary[i][e], new Vector3(startingX, startingY, 0.0f), Quaternion.identity);
                startingY--;
            }
            startingX= startingX+1.3f;
        }
        //Vector2 startingPosition = new Vector2()
    }
}
