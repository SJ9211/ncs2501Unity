using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class TaskExample : MonoBehaviour
{

    void Start()
    {
        Task.Factory.StartNew(() => { Debug.Log("Task"); });
        Task task2 = new Task(new Action(Debuglog));
        task2.Start();

        Task task3 = new Task(delegate { Debuglog(); });
        task3.Start();

        Task task4 = new Task(() => Debuglog());
        task4.Start();

        Task task5 = new Task(() => Debuglog());
        task5.Start();

        task2.Wait();
        task3.Wait();
        task4.Wait();
        task5.Wait();

        Task<int> task = Task.Factory.StartNew<int>(() => GetSize("GgnericTask"));
        int result = task.Result;
        Debug.Log(result);
    }


    int GetSize(string data)
    {
        return data.Length;
    }

    
    void Debuglog()
    {
        Debug.Log("Task");
    }
}
