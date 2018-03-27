using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    /*private int attack = 1;
    private int hitRange = 1;
    public Transform Enemy;*/
    public float attackDuration = 0.3f;
    public bool attacking;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // have the player initiate an attack on the object
        if (Input.GetKeyUp(KeyCode.F))
        {
            //MeleeAttack();
            attacking = true;
        }
        //EnableDamage();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Enemy")
        {
            if (col.tag == "Enemy")
            {
                col.SendMessage("Hit", 1, SendMessageOptions.DontRequireReceiver);
            }
        }
        attacking = false;
    }

    void EnableDamage()
    {
        if (attacking == true) return;
        attacking = true;
        StartCoroutine("DisableDamage");
    }

    IEnumerator DisableDamage()
    {
        yield return new WaitForSeconds(attackDuration);
        attacking = false;
    }
    /*private void MeleeAttack()
    {
        // create a variable called distance to make sure the distance is close enough
        // to inflict damage from a melee attack target.transform.positon = the position
        // of the object to attack and transform.position is the position of the players
        // transform
        float distance = Vector3.Distance(Enemy.transform.position, transform.position);

        // make sure the distance is not greater than 1.5 so the player cannot
        // melee an enemy from to far away
        if (distance < 1.5f)
        {
            // get a reference to the enemy's health script and type cast it.
            EnemyHealth eh = (EnemyHealth)Enemy.GetComponent("EnemyHealth");
            // now call the function that will decrease the enemy's health
            eh.TakeDamage(1);
        }
    }*/
}
