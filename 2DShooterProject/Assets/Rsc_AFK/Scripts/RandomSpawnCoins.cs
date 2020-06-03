using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnCoins : MonoBehaviour
{
    // Food prefab
    public GameObject BronzeCoin;
    public GameObject SilverCoin;
    public GameObject GoldCoin;
    public GameObject DiamondCoin;
    public GameObject CrystalCoin;

    // Borders
    public Transform Border_Top;
    public Transform Border_Bottom;
    public Transform Border_Left;
    public Transform Border_Right;

    // Start is called before the first frame update
    void Start()
    {
        // Spawn Heal1 every 20 seconds, starting in 2
        InvokeRepeating("Spawn1", 2, 5);
        InvokeRepeating("Spawn2", 4, 6);
        InvokeRepeating("Spawn3", 6, 8);
        InvokeRepeating("Spawn4", 8, 10);
        InvokeRepeating("Spawn5", 10, 15);

        for (int i = 0; i < 5; i++)
        {
            Invoke("Spawn1", 1);
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
        Instantiate(BronzeCoin,
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
        Instantiate(SilverCoin,
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
        Instantiate(GoldCoin,
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
        Instantiate(DiamondCoin,
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
        Instantiate(CrystalCoin,
                    new Vector2(x, y),
                    Quaternion.identity); // default rotation
    }
}
