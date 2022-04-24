using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] float carSpeed = 5f;
    [SerializeField] Sprite[] sprites;
    bool obstacle = false;

    // Start is called before the first frame update
    void Start()
    {
        SpritePicker();
    }

    private void SpritePicker()
    {
        int pickSprite = Random.Range(0, sprites.Length);
        GetComponent<SpriteRenderer>().sprite = sprites[pickSprite];
    }

    // Update is called once per frame
    void Update()
    {
        if (obstacle) return;
        Move();
    }

    private void Move()
    {
        gameObject.transform.Translate(Vector2.up * Time.deltaTime * carSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
            obstacle = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.position.y < transform.position.y)
        {
            obstacle = false;
        }
    }
}
