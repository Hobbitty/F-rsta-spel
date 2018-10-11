using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer rend;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    private bool left;
    private bool right;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ChangeSprite();
    }
    void ChangeSprite()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rend.sprite = sprite2;
            left = true;
        }
        else
        {
            left = false;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rend.sprite = sprite1;
            right = true;
        }
        else
        {
            right = false;
        }
        if (left == false && right == false)
        {
            rend.sprite = sprite3;
        }
    }
}
