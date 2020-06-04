using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnHeal : MonoBehaviour
{
    // Food prefab
    public GameObject Heal1;
    public GameObject Heal2;
    public GameObject Heal3;
    public GameObject Heal4;
    public GameObject Heal5;
    public GameObject HealArea;

    // Borders
    public Transform Border_Top;
    public Transform Border_Bottom;
    public Transform Border_Left;
    public Transform Border_Right;

    // Start is called before the first frame update
    void Start()
    {
        // Spawn Heal1 every 20 seconds, starting in 2
        InvokeRepeating("Spawn1", 2, 20);

        // Spawn Heal2 every 20 seconds, starting in 6
        InvokeRepeating("Spawn2", 6, 20);

        // Spawn Heal3 every 20 seconds, starting in 10
        InvokeRepeating("Spawn3", 10, 20);

        // Spawn Heal4 every 20 seconds, starting in 14
        InvokeRepeating("Spawn4", 14, 20);

        // Spawn Heal5 every 20 seconds, starting in 20
        InvokeRepeating("Spawn5", 18, 20);

        for(int i = 0; i < 25; i++)
        {
            Invoke("SpawnArea", 1);
        }
    }

    // Spawn one piece of food
    void Spawn1()
    {
        // x position between left & right border
        int x = (int)Random.Range(Border_Left.position.x,
                                  Border_Right.position.x);

        // y position between top & bottom border
        int y = (int)Random.Range(Border_Bottom.position.y,
                                  Border_Top.position.y);

        // Instantiate the food at (x, y)
        Instantiate(Heal1,
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

        // Instantiate the food at (x, y)
        Instantiate(Heal2,
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

        // Instantiate the food at (x, y)
        Instantiate(Heal3,
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

        // Instantiate the food at (x, y)
        Instantiate(Heal4,
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

        // Instantiate the food at (x, y)
        Instantiate(Heal5,
                    new Vector2(x, y),
                    Quaternion.identity); // default rotation
    }

    void SpawnArea()
    {
        // x position between left & right border
        int x = (int)Random.Range(Border_Left.position.x,
                                  Border_Right.position.x);

        // y position between top & bottom border
        int y = (int)Random.Range(Border_Bottom.position.y,
                                  Border_Top.position.y);

        // Instantiate the food at (x, y)
        Instantiate(HealArea,
                    new Vector2(x, y),
                    Quaternion.identity); // default rotation
    }

}
