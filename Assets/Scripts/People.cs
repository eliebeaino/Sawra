using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class People : MonoBehaviour
{
    [SerializeField] float walkSpeed = 1f;
    bool move = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (move)
        {
            gameObject.transform.Translate(Vector2.down * Time.deltaTime * walkSpeed);
        }
    }

    public void StopMove()
    {
        move = false;
    }
}
