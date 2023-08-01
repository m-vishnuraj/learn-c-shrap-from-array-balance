using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // for loop
        for(int i=1; i<=5; i++)
        {
            print("Ram");
        }

        // while loop
        int j = 1;
        while(j<=5)
        {
            print("Shyam");
            j++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
