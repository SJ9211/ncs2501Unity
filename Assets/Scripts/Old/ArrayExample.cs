using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] Avengers = new string[] {"Iron Man","Captain America","Spider Man"};
        string[] DCComics = new string[4];
        DCComics[0] = "Aqua Man";
        DCComics[1] = "Super Man";
        DCComics[2] = "Bat Man";
        DCComics[3] = "Wonder Woman";

        //string[,] Heroes = new string[2,3]{{"Iron","Captain","Spider"},{"Aqua","Super","Bat"}};
        // string[,] Heroes = new string[,]{{"Iron","Captain","Spider"},{"Aqua","Super","Bat"}};
        var Heroes = new string[,]{{"Iron","Captain","Spider"},{"Aqua","Super","Bat"}}; // 2차원 배열 3차원은{}= 1개더 추가

        //  string[][] newHeroes = new string[2][];
        //  newHeroes[0] = new string[]{"Ireon","Captain","Spider"};
        //  newHeroes[1] = new string[4]{"Aqua","Supre","Bat","Wonder"};
        
        // string[][] newHeroes = new string[][]
        // {
        //     new string[]{"Ireon","Captain","Spider"},
        //     new string[]{"Aqua","Supre","Bat","Wonder"}
        // };
        
        string[][] newHeroes = 
        {
            new string[]{"Ireon","Captain","Spider"},
            new string[]{"Aqua","Supre","Bat","Wonder"}
        };

        Debug.Log(Heroes[1,3]);
        Debug.Log(newHeroes[1][2]);

    }

     public void TwoDA20neDA()
     {
        int[,] array2d = new int[,]{{1,2},{3,4},{5,6}};
        int[] array1d
        =new int[array2d.GetLength(0) * array2d.GetLength(1)];

        // 2D -> 1D
        for (int i = 0; i < array2d.GetLength(0); i++)
        {
            for (int k = 0; k <array2d.GetLength(1); k++)
            {
                array1d[array2d.GetLength(1)* i + k]
                = array2d[i,k];
            }
        }
     }

}

 
