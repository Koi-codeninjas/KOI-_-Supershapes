using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{

    // movement speed
    [Header("Deafault Movement Speed")]
    public float moveSpeed = 600f;
    //movement float
    float movement = 0f;

    // Start is called before the first frame update
    void Start()
    {
        // gam running at a playing state
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Movement equals to horizontal
        // axis movent (Left or right
        movement = Input.GetAxisRaw("Horizontal");

    }
    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.Find("GameController").GetComponent<GameController>().GameOver();
    }
}
