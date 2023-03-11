using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    //hexagon game object
    [Header("Shape Objects")]
    public GameObject[] shapePrefabs;
    //Spawn rate for how many objects are spawned
    [Header("Default spawn delay time")]
    public float spawnDelay = 2f;
    [Header("Default Spawn time")]
    public float spawnTime = 3f;

    [Header("Game Over UI Object")]
    public GameObject gameOverCanvas;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnDelay, spawnTime);
    }

    void Spawn()
    {
        //random range for shape objects to be spawned
        int randomInt = Random.Range(0, shapePrefabs.Length);
        //spawn new hexagon at pos
        Instantiate(shapePrefabs[randomInt], Vector3.zero, Quaternion.identity);
    }

    // Game over function
    public void GameOver()
    {
        //stops spawn function
        CancelInvoke("Spawn");

        //you can see the game over canvas
        gameOverCanvas.SetActive(true);
        //game is at a stopping state
        Time.timeScale = 0;
    }


    // Update is called once per frame
    void Update()
    {

    }
}
