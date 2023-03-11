using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{

    [Header("Rigidbody Object")]
    public Rigidbody2D rb;
    //shrinking speed
    [Header("Default Shrinking Speed")]
    public float shrinkSpeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        rb.rotation = Random.Range(0f, 360f);
        /*
         * local scale for the hexagon
         * eqauls one for all axes times
         * ten
         */
        transform.localScale = Vector3.one * 10f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;
      if (transform.localScale.x <= .05f)
        {
            Destroy(gameObject);
            //add one to score
            Score.score++;
        }
    }
}
