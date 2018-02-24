using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {

    private static InputController instance;
    public bool IsVisible = true;
    public GameObject level;

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
        float res = Input.GetAxis(player + axis);
        if(res != 0)
        {
            MakeInvisible();
        }
        return res;
    }

    public bool getButtonDown(int player, KeyCode button, string key)
    {
        bool res = Input.GetKeyDown((KeyCode)(player * 20) + (int)button) || Input.GetButtonDown(player + key);
        if (res)
        {
            MakeInvisible();
        }
        return res;
    }

    public bool getButtonUp(int player, KeyCode button, string key)
    {
        bool res = Input.GetKeyUp((KeyCode)(player * 20) + (int)button) || Input.GetButtonDown(player + key);
        if (res)
        {
            MakeInvisible();
        }
        return res;
    }

    public void MakeInvisible()
    {
        level.GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f, 0f);
    }

    public void MakeVisible()
    {
        level.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
    }
}
