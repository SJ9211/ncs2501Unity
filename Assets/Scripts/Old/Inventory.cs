using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class Inventory : MonoBehaviour
{
      public class Stuff
    {
        public int bullets;
        public int grenades;
        public int rockets;
        public float fuel;
        public Stuff(int bul, int gre, int roc)
        {
            bullets = bul;
            grenades = gre;
            rockets = roc;
        
        }
        public Stuff(int bul, float fu)
        {
            bullets = bul;
            fuel = fu;
        }
        //생성자
        public Stuff()
        {
            bullets = 1;
            grenades = 1;
            rockets = 1;
        }
    }
    //  Stuff 클래스의 인스턴스(오브젝트) 생성
    public Stuff myStuff = new Stuff(50, 5, 5);
    public Stuff myOtherStuff = new Stuff (50, 1.5f);

    void Start()
    {
        Debug.Log(myStuff.bullets);
    }
}
