using UnityEngine;
using System.Diagnostics;
using Debug = UnityEngine.Debug;




namespace Jungse
{
    public class NamespaceDefinitionExample
    {
        public void DebugLog(string message)
        {
            UnityEngine.Debug.Log(message);
        }

        public static void StaticSample()
        {
            UnityEngine.Debug.Log("Static");
        }

        public static int  GetData(int a)
        {
            return 0;
        }
    }
}