using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    List<int> list = new();
    public int a;
    // Start is called before the first frame update
    void Start()
    {
        print(a);
        print(list.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {
        print(a);
    }

}
