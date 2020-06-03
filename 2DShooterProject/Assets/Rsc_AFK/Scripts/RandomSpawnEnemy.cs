using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnEnemy : MonoBehaviour
{
    //Enemy
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public GameObject Enemy4;
    public GameObject Enemy5;
    public GameObject Enemy6;
    public GameObject Enemy7;
    public GameObject Enemy8;
    public GameObject Enemy9;
    public GameObject Enemy10;

    // Borders
    public Transform Border_Top;
    public Transform Border_Bottom;
    public Transform Border_Left;
    public Transform Border_Right;

    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("Spawn1", 1, 10);
        InvokeRepeating("Spawn2", 2, 10);
        InvokeRepeating("Spawn3", 3, 10);
        InvokeRepeating("Spawn4", 4, 10);
        InvokeRepeating("Spawn5", 5, 10);
        InvokeRepeating("Spawn6", 6, 10);
        InvokeRepeating("Spawn7", 7, 10);
        InvokeRepeating("Spawn8", 8, 10);
        InvokeRepeating("Spawn9", 9, 10);
        InvokeRepeating("Spawn10", 10, 10);
        

    }

    // Spawn one enemy
    void Spawn1()
    {
        // x position between left & right border
        int x = (int)Random.Range(Border_Left.position.x,
                                  Border_Right.position.x);

        // y position between top & bottom border
        int y = (int)Random.Range(Border_Bottom.position.y,
                                  Border_Top.position.y);

        // Instantiate the food at (x, y)
        Instantiate(Enemy1,
                    new Vector2(x, y),
                    Quaternion.identity); // default rotation
           
    }

    void Spawn2()
    {
        // x position between left & right border
        int x = (int)Random.Range(Border_Left.position.x,
                                  Border_Right.position.x);

        // y position between top & bottom border
        int y = (int)Random.Range(Border_Bottom.position.y,
                                  Border_Top.position.y);
        Instantiate(Enemy2,
                   new Vector2(x, y),
                   Quaternion.identity); // default rotation


    }



    void Spawn3()
    {
        // x position between left & right border
        int x = (int)Random.Range(Border_Left.position.x,
                                  Border_Right.position.x);

        // y position between top & bottom border
        int y = (int)Random.Range(Border_Bottom.position.y,
                                  Border_Top.position.y);
        Instantiate(Enemy3,
                   new Vector2(x, y),
                   Quaternion.identity); // default rotation


    }

    void Spawn4()
    {
        // x position between left & right border
        int x = (int)Random.Range(Border_Left.position.x,
                                  Border_Right.position.x);

        // y position between top & bottom border
        int y = (int)Random.Range(Border_Bottom.position.y,
                                  Border_Top.position.y);
        
        Instantiate(Enemy4,
                    new Vector2(x, y),
                    Quaternion.identity); // default rotation


    }

    void Spawn5()
    {
        // x position between left & right border
        int x = (int)Random.Range(Border_Left.position.x,
                                  Border_Right.position.x);

        // y position between top & bottom border
        int y = (int)Random.Range(Border_Bottom.position.y,
                                  Border_Top.position.y);
        
        Instantiate(Enemy5,
                    new Vector2(x, y),
                    Quaternion.identity); // default rotation
    }

    void Spawn6()
    {
        // x position between left & right border
        int x = (int)Random.Range(Border_Left.position.x,
                                  Border_Right.position.x);

        // y position between top & bottom border
        int y = (int)Random.Range(Border_Bottom.position.y,
                                  Border_Top.position.y);
        
        Instantiate(Enemy6,
                    new Vector2(x, y),
                    Quaternion.identity); // default rotation


    }

    void Spawn7()
    {
        // x position between left & right border
        int x = (int)Random.Range(Border_Left.position.x,
                                  Border_Right.position.x);

        // y position between top & bottom border
        int y = (int)Random.Range(Border_Bottom.position.y,
                                  Border_Top.position.y);
        
        Instantiate(Enemy7,
                    new Vector2(x, y),
                    Quaternion.identity); // default rotation


    }

    void Spawn8()
    {
        // x position between left & right border
        int x = (int)Random.Range(Border_Left.position.x,
                                  Border_Right.position.x);

        // y position between top & bottom border
        int y = (int)Random.Range(Border_Bottom.position.y,
                                  Border_Top.position.y);
        
        Instantiate(Enemy8,
                    new Vector2(x, y),
                    Quaternion.identity); // default rotation


    }

    void Spawn9()
    {
        // x position between left & right border
        int x = (int)Random.Range(Border_Left.position.x,
                                  Border_Right.position.x);

        // y position between top & bottom border
        int y = (int)Random.Range(Border_Bottom.position.y,
                                  Border_Top.position.y);
        Instantiate(Enemy9,
                    new Vector2(x, y),
                    Quaternion.identity); // default rotation

    }

    void Spawn10()
    {
        // x position between left & right border
        int x = (int)Random.Range(Border_Left.position.x,
                                  Border_Right.position.x);

        // y position between top & bottom border
        int y = (int)Random.Range(Border_Bottom.position.y,
                                  Border_Top.position.y);
        
        Instantiate(Enemy10,
                    new Vector2(x, y),
                    Quaternion.identity); // default rotation
    }



    }
