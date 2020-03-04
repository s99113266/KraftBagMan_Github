using UnityEngine;

public class Play : MonoBehaviour
{
    public PlayData playData;
    private Animator animator;
    private Transform Playr;
    private Rigidbody2D rig;
    private void Start()
    {
        animator = GetComponent<Animator>();
        Playr = gameObject.transform;
        rig = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            
            animator.SetInteger("jump",1);
            rig.AddForce(new Vector2(Playr.position.x, playData.JumpHeight) * Time.deltaTime);
        }


        float PlayrRun = Input.GetAxisRaw("Horizontal");
        if (PlayrRun != 0)
        {
            animator.SetBool("run",true);
            
            rig.AddForce(new Vector2(Input.GetAxisRaw("Horizontal") * playData.Speed, Playr.position.y) * Time.deltaTime);

            print(Input.GetAxis("Horizontal"));

            if (PlayrRun > 0)
            {
                Playr.eulerAngles = new Vector3(0, 180, 0);
            }
            else if (PlayrRun < 0)
            {
                Playr.eulerAngles = new Vector3(0, 0, 0);
            }


        }
        else if (Input.GetAxisRaw("Horizontal") == 0 && animator.GetBool("run") == true)
        {
           
            animator.SetBool("run",false);
        }

    }
}
