using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("Left was pressed");

            //transform.Translate(Vector2.left * Speed * Time.deltaTime);
        }
    }
}
