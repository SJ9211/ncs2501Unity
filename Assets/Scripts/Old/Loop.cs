using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class Loop : MonoBehaviour
{
    int numEnemies = 3;
    void Start()
    {
        ForeaChLoop();
    }
    void ForLoop()
    {
           // for ㅁ 뜨면 Tab를 누르면 코드가 자동완성됌
        //for (int k = 0; k < 1000; k++)
        //{
            
        //}
        int a = 0;
        for(int i = 0; i < 10; i++) 
        {
            a++;
        }


        for (int i = 0; i < numEnemies; i++)
        {
            Debug.Log("Creating enemy number:" + i);
        }
     }

     void WhileLoop()
     {
        
        int cupsInTheSink = 4;

        while (cupsInTheSink > 0)
        {
            //Debug.Log("I've washed a cup!");
            cupsInTheSink--;
        }

        cupsInTheSink = 4;
        for (int i = 0; i < cupsInTheSink; i++)
        {
            Debug.Log("I've washed a cup!");
        }
    }

    void DOwhile()
    {
        bool shouldContinue = false;
        do
        {
            print("Hello world");
        } while (shouldContinue == true);
    }

    void ForeaChLoop()
    {
        
        var strings = new string[3];

        strings[0] = "First string";
        strings[1] = "Second string";
        strings[2] = "Third string";

        foreach(var item in strings)
        {
             print (item);
        }
      
       for (int i =0; i < strings.Length; i++)
       {
          if (i == 0)
          {
              print("start!");
          }
          print(strings[i]);
       }
    
    }
}
