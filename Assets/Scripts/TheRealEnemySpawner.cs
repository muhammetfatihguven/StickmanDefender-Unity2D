using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheRealEnemySpawner : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject Enemy2;
    public GameObject SpawnPoint;
    public static float spawnspeed;
    public static float spawnspeed2 = 75f;
    public static float spawnspeed2start = 75f;
   
    void Start()
    {
        
    
        if (MoneyScript.waveValue == 1)
        {
            sunMoveScript.controlledspeed = 0.0980f;
            spawnspeed = 1.8f;
        }
        
        else if (MoneyScript.waveValue == 2)
        {
            sunMoveScript.controlledspeed = 0.0890f;
            spawnspeed = 1.30f;
        }

        else if (MoneyScript.waveValue == 3)
        {
            sunMoveScript.controlledspeed = 0.0835f;
            spawnspeed = 1.15f;
        }

        else if (MoneyScript.waveValue == 4)
        {
            sunMoveScript.controlledspeed = 0.0800f;
            spawnspeed = 1f;
        }

        else if (MoneyScript.waveValue == 5)
        {
            sunMoveScript.controlledspeed = 0.0750f;
            spawnspeed = 0.9f;
        }

        else if (MoneyScript.waveValue == 6)
        {
            sunMoveScript.controlledspeed = 0.0725f;
            spawnspeed = 0.86f;
            spawnspeed2start = 3.0f;
            spawnspeed2 = 6.1f;
        }

        else if (MoneyScript.waveValue == 7)
        {
            sunMoveScript.controlledspeed = 0.07f;
            spawnspeed = 0.86f;
            spawnspeed2start = 3.0f;
            spawnspeed2 = 5.7f;
        }

        else if (MoneyScript.waveValue == 8)
        {
            sunMoveScript.controlledspeed = 0.0675f;
            spawnspeed = 0.86f;
            spawnspeed2start = 3.0f;
            spawnspeed2 = 5.4f;
        }

        else if (MoneyScript.waveValue == 9)
        {
            sunMoveScript.controlledspeed = 0.06f;
            spawnspeed = 0.86f;
            spawnspeed2start = 3.0f;
            spawnspeed2 = 5f;
        }

        else if (MoneyScript.waveValue == 10)
        {
            sunMoveScript.controlledspeed = 0.0475f;
            spawnspeed = 0.80f;
            spawnspeed2start = 2.0f;
            spawnspeed2 = 4f;
        } //
        else if (MoneyScript.waveValue == 11)
        {
                SceneManager.LoadScene("WinScreen");
        }
    


        InvokeRepeating("Spawner", 1.0f, spawnspeed);
        InvokeRepeating("Spawner2", spawnspeed2start, spawnspeed2);
    }
    void Spawner()
    {
        GameObject Enemyy = Instantiate(Enemy, new Vector3(SpawnPoint.transform.position.x,
        SpawnPoint.transform.position.y, 0), Quaternion.identity);
        Enemyy.name = "Enemy";
        
    }

    void Spawner2()
    {
        GameObject Enemyyy = Instantiate(Enemy2, new Vector3(SpawnPoint.transform.position.x,
        SpawnPoint.transform.position.y, 0), Quaternion.identity);
        Enemyyy.name = "Enemy2";
        
    }
}
