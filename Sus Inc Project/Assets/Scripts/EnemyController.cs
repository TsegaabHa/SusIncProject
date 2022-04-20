using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 10.0f;
    public bool turnLeft = false;
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(bulletPrefab, transform.position, Quaternion.identity);

        if (!turnLeft)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);


        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);

        }
        if(transform.position.x >= 15)
        {
            turnLeft = true;


        }
        if(transform.position.x <= 5)
        {
            turnLeft = false;
    
        }

    }
}
