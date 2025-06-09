using UnityEngine;
using UnityEngine.InputSystem;


public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool alive = true;

    public AudioScript audioManage;

    void Awake()
    {
        audioManage = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioScript>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Keyboard.current.spaceKey.wasPressedThisFrame && alive){
            audioManage.playSFX(audioManage.flap);
            myRigidbody.linearVelocity = Vector2.up* flapStrength;
        }

        if (transform.position.y < -39 || transform.position.y > 39)
        {
            if(alive)
            {
                audioManage.playSFX(audioManage.death);
            }            
            logic.gameOver();
            alive = false;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (alive)
        {
            audioManage.playSFX(audioManage.death);
        }
        logic.gameOver();
        alive = false;
    }
}
