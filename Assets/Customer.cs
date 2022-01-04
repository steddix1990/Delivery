using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{
    [SerializeField] int packageGoal = 5;
    int numberOfPackages = 0;

    void Start()
    {
        Debug.Log(numberOfPackages);
    }

    void packageDelivered()
    {
        numberOfPackages++;
        Debug.Log(numberOfPackages);

        if (numberOfPackages >= packageGoal)
        {
            Goal();
        }
    }

    void Goal()
    {
        Debug.Log(numberOfPackages + " Packages successfully delivered!");
        Destroy(gameObject);

        // play a lovely sprite, game over text etc.
    }
}
