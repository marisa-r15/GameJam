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
            EnemyAnim.SetBool("MoveRight",true);

        }
        else{
            transform.Translate(-2 * Time.deltaTime * speed , 0 , 0);
            EnemyAnim.SetBool("MoveRight",false);
        }
    }
}
