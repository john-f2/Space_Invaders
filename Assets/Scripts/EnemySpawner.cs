using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawner : MonoBehaviour
{
    //initX and initY used for instantiating the enemy objects
    public float initX;
    public float initY;
    public bool shootingAllowed;
    public GameObject enemyPrefab1;
    public GameObject enemyPrefab2;
    public GameObject enemyPrefab3;

    //wait time variable, used to delay enemy shooting
    float waitTime = 0.0f;

    //Enemy Dictionary, used to store the enemies 
    //each list represents a col of enemies 
    private Dictionary<int, List<GameObject>> enemyDictionary = new Dictionary<int, List<GameObject>>();

    //simple array used to keep track of which col still has enemies 
    //used in Enemy shooting to choose a col to shoot from 
    //if the col has no more enemies, then the col is removed from the array 
    int[] hasEnemies = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
    Vector2 move;
    bool right = false;
    bool down = false;
    private void Awake()
    {
        waitTime += Random.Range(1.0f, 4.0f);
        shootingAllowed = true;

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
        move = Vector2.left *Time.deltaTime;
        if (Time.time > waitTime)
        {
            enemyShooting();
        }
        for (int i = 0; i < 11; i++)
        {
            for(int j =0; j < enemyDictionary[i].Count; j++)
            {
                if (enemyDictionary[i][j] == null)
                    continue;
                if (enemyDictionary[i][j].GetComponent<Transform>().position.x <= -10)
                {
                    right = true;
                    shiftDown();
                }
                if(right)
                {
                    move = Vector2.right * Time.deltaTime;
                }
                if(enemyDictionary[i][j].GetComponent<Transform>().position.x > 10)
                {
                    right = false;
                    shiftDown();
                }
                enemyDictionary[i][j].GetComponent<Transform>().Translate(move);
                
            }
        }
  

    }
    /*
     * shifts the enemies down
     */
    void shiftDown()
    {
        for (int i = 0; i < 11; i++)
        {
            for (int j = 0; j < enemyDictionary[i].Count; j++)
            {
                if (enemyDictionary[i][j] == null)
                    continue;
                enemyDictionary[i][j].GetComponent<Transform>().Translate(Vector2.down * Time.deltaTime);
            }
        }
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
            enemyDictionary[i].Add(enemyPrefab1);
            enemyDictionary[i].Add(enemyPrefab1);
            enemyDictionary[i].Add(enemyPrefab2);
            enemyDictionary[i].Add(enemyPrefab2);
            enemyDictionary[i].Add(enemyPrefab3);


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
                GameObject newEnemy = Instantiate(enemyDictionary[i][e], new Vector3(startingX, startingY, 0.0f), Quaternion.identity);
                //replaces the old gameObject in the dict with the new instantiated one
                enemyDictionary[i][e] = newEnemy;
                startingY++;
            }
            startingX= startingX+1.3f;
        }
        //Vector2 startingPosition = new Vector2()
    }

    /* Enemies are choosen randomly to shoot, the only enemies that shoot are in the last of the column */
    private void enemyShooting()
    {

        int numberOfshooters = Random.Range(1, 4);

        int previousShootingCol = -1;
        if (shootingAllowed)
        {
            for (int i = 0; i < numberOfshooters; i++)
            {

                int shootingCol = hasEnemies[Random.Range(0, hasEnemies.Length)];
                if (shootingCol != previousShootingCol)
                {
                    //finds the first avaliable enemy in the list
                    //then calls shoot function 
                    foreach (GameObject enemy in enemyDictionary[shootingCol])
                    {
                        if (enemy != null)
                        {
                            enemy.gameObject.GetComponent<EnemyScript>().shoot();
                            break;
                        }
                    }
                    previousShootingCol = shootingCol;

                }



            }
        }
        //delays shooting by 1 to 4 seconds 
        waitTime = Time.time + (Random.Range(1.0f, 3.2f));
    }

    void testPostion()
    {
        for(int i =0; i<11;i++)
        {
            for(int en =0; en < enemyDictionary[i].Count; en++)
            {
                Debug.Log(enemyDictionary[i][en].transform.position);
            }
            Debug.Log("break");
        }
    }

}
