using LuaInterface;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestToLua : MonoBehaviour
{
    LuaState state;
    // Start is called before the first frame update
    void Start()
    {
        state = new LuaState();
        state.Start();
        state.DoFile("Main.lua");

        LuaFunction func = state.GetFunction("Main");
        func.Call();
        func.Dispose();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
