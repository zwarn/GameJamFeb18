using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {

    private static InputController instance = null;
    public static InputController getInstance()
    {
        return instance;
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public float getAxis(int player, string axis)
    {
        return Input.GetAxis(player + axis);
    }

    public bool getButtonDown(int player, KeyCode button, string key)
    {
        return Input.GetKeyDown((KeyCode)(player * 20) + (int)button) || Input.GetButtonDown(player + key);
    }

    public bool getButtonUp(int player, KeyCode button, string key)
    {
        return Input.GetKeyUp((KeyCode)(player * 20) + (int)button) || Input.GetButtonDown(player + key);
    }


}
