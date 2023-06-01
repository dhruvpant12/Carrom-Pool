using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Striker : MonoBehaviour
{
    Rigidbody2D strikerRB;
    [SerializeField] float forcehit=1000f;
    Vector3 pointOnboard;
    Vector3 direction;
    Vector2 fireDirection;
    [SerializeField] GameObject strikerOwnerPosition;

    bool strikerMoving = false; // Can only launch striker if it is not moving and is in launch range.

    private void Awake()
    {
        strikerRB = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    private void FixedUpdate()
    {
        if(!strikerMoving)
            FireStriker(); // Launch the Striker.

       if( strikerRB.velocity.magnitude <0.2f && strikerRB.velocity.magnitude!=0) // If stiker speed is too low , make it stop.
        {
            strikerMoving = false;
            transform.position = strikerOwnerPosition.transform.position;
        }
    }

    void FireStriker()
    {
        if (Input.GetMouseButtonDown(0))
        {
            pointOnboard = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            print(pointOnboard);
            direction = pointOnboard - transform.position;
            direction.Normalize();
            fireDirection = new Vector2(direction.x, direction.y);

            strikerRB.AddForce(fireDirection * forcehit);

            strikerMoving = true;

        }
    }
}
