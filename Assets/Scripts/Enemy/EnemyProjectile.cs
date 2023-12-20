using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    // change the speed in the unity
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        transform: accesses the transform component of the object, which controls its position
        translate: a geometry function thaat slides the object along a straight path
        vector2.down: the direction we want the projectiles to move
        speed: a value can be set from within unity
        time.deltatime: makes the projectiles move every second instead of every frame
        */
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
    //ontriggerenter2d: this function will run whenever the trigger enters another collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
                }
    }
}
