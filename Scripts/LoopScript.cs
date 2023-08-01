using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopScript : MonoBehaviour
{
    // Start is called before the first frame update

    // public GameObject[] objects;
    public int power = 0;
    void Start()
    {
        // for loop
        // for(int i=1; i<=5; i++)
        // {
        // print("Ram");
        // }

        // while loop
        // int j = 1;
        // while(j<=5)
        // {
        //   print("Shyam");
        //    j++;
        // }

        // foreach loop

        // foreach(GameObject o in objects)
        //{
            // Destroy(o);
         //   o.SetActive(true);
       // }

        // switch case
        switch(power)
        {
            case 0:
                print("Power is 0");
                break;
            case 1:
                print("Power is 1");
                break;
            case 2:
                print("Power is 2");
                break;
            default:
                print("Power is not 0,1,2");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
