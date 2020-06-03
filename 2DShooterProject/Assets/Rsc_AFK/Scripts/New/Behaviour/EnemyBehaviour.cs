using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBehaviour : MonoBehaviour
{
    public float bounds = 100;

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x > bounds || this.transform.position.x < -bounds || this.transform.position.y > bounds || this.transform.position.x < -bounds)
        {

            Destroy(gameObject);

        }
    }
}
