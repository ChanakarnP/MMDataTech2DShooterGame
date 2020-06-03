using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayer : MonoBehaviour
{
    private float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    public GameObject bullet;
    public GameObject muzzle;

    // Update is called once per frame
    void Update()
    {
        Vector2 dir = Vector2.up;
        if (Input.GetMouseButtonDown(0))
        {

            Instantiate(bullet, muzzle.transform).GetComponent<Rigidbody2D>().AddForce(dir * 10, ForceMode2D.Impulse);


        }


    }
}