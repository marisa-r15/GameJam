using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D PlayerBody;
    private Vector3 change;
    private Animator PlayerAnim;

    void Start()
    {
        PlayerBody = GetComponent<Rigidbody2D>();
        PlayerAnim = GetComponent<Animator>();
        

    }

    // Update is called once per frame
    void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        PlayerAnimAndMove();
        MoveCharacter();
    }

    void PlayerAnimAndMove()
    {
        if(change != Vector3.zero)
        {
            MoveCharacter();
            PlayerAnim.SetFloat("MoveX", change.x);
            PlayerAnim.SetFloat("MoveY", change.y);
            PlayerAnim.SetBool("Moving", true);
            }else{PlayerAnim.SetBool("Moving",false);}
    }
    void MoveCharacter()
    {
        PlayerBody.MovePosition(
        transform.position + change * speed * Time.deltaTime);
    }
}
