using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;
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
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            audioManage.playSFX(audioManage.pointCollect);
            logic.addScore(1);
        }
        
    }
}
