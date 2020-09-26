using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    public bool MoveRight;
    private Animator EnemyAnim;

    // Start is called before the first frame update
    void Start()
    {
        EnemyAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(MoveRight){
            transform.Translate(2 * Time.deltaTime * speed , 0 , 0);
            EnemyAnim.SetBool("Move Right",true);

        }
        else{
            transform.Translate(-2 * Time.deltaTime * speed , 0 , 0);
            EnemyAnim.SetBool("Move Right",false);
        }
    }
    void OnTriggerEnter2D(Collider2D trig)
    {
        if(trig.gameObject.CompareTag("turn")){
                if(MoveRight){
                    MoveRight = false;
                }
                else{
                    MoveRight = true;
                }
        }
    }
}
