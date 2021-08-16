using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float runSpeed = 2; //para el movimiento en el eje horizontal
    public float jumpSpeed = 3;  //
    Rigidbody2D rb2D; //para la física, movimiento, velocidad, gravedad
    public bool betterJump = false; //para activar o desactivar salto más fuerte si se teclea más pisado la barra espaciadora
    public float fallMultiplier = 0.5f;  //si se pulsa más o menos  el espacio
    public float lowJumpMultiplier = 1f; // ^^ ^
    public SpriteRenderer spriteRenderer; 
    public Animator animator; //referencia al cuadro de animacion
   
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>(); //hacer referencia rigidbody del personaje
    }

    void FixedUpdate()
    {
        if (Input.GetKey("d") || Input.GetKey("right")) //si se pulsa la letra d o tecla -> va a la derecha
        {
            rb2D.velocity = new Vector2(runSpeed, rb2D.velocity.y);
            spriteRenderer.flipX = false; //para que mire a la derecha
            animator.SetBool("Run", true); //para que se active variable de animación de correr (se muevan los pies)
           
        }
        else if (Input.GetKey("a") || Input.GetKey("left")) //si se pulsa la letra a o tecla <- va a la izquierda
        {
            rb2D.velocity = new Vector2(-runSpeed, rb2D.velocity.y);
            spriteRenderer.flipX = true; //para que se quede viendo a la izquierda
            animator.SetBool("Run", true);
           
        }
        else
        {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
            animator.SetBool("Run", false); //para que se desactive variable de animación de correr (se muevan los pies)
            
        }
        if (Input.GetKey("space") && CheckGround.isGrounded) 
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
        }
        if (CheckGround.isGrounded==false) { //cuando no esté en el suelo
            animator.SetBool("Jump", true); //active el parametro de la animación de salto, estamos saltando
            animator.SetBool("Run", false); // para que no corra mientras salta
        }
        if (CheckGround.isGrounded == true) { //si está en el suelo
            animator.SetBool("Jump", false);  //desactiva el parametro de la animación de salto 
        }
        if (betterJump) //si betterJump está activado haremos el tipo de salto bajo o más fuerte con la barra esp
        {
            if (rb2D.velocity.y < 0) //si la velocidad en el eje y es menor a 0
            {
                //tomar la velocidad en el eje y de nuestro personaje multiplicarlo por la gravedad y multiplicarlo por
                //la gravedad y Time.deltaTime para que no haya inconsistencia en los frames por segundo
                rb2D.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier) * Time.deltaTime; 
            }
            if (rb2D.velocity.y > 0 && !Input.GetKey("space")) //si no se pulsa la barra espaciadora
            {
                rb2D.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier) * Time.deltaTime;
            }
        }
       
        }
    }

