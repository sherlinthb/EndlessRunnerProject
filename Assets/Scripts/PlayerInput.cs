using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

[RequireComponent(typeof(Player))]
public class PlayerInput : MonoBehaviour
{

    Player player;
    

    void Start()
    {

        player = GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 directionalInput = new Vector2(CrossPlatformInputManager.GetAxisRaw("Horizontal"), CrossPlatformInputManager.GetAxisRaw("Vertical"));
        Vector2 directionalInput2 = new Vector2(1, Input.GetAxisRaw("Vertical"));

        //player.SetDirectionalInput(directionalInput);
        player.SetDirectionalInput(directionalInput2);
        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            player.OnjumpInputDown();
        }

        if (CrossPlatformInputManager.GetButtonUp("Jump"))
        {
            player.OnJumpInputUp();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.OnjumpInputDown();

        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            player.OnJumpInputUp();
        }
    }

    // not being used currently
    public void upKey()
    {

    }

    public void rightKey()
    {
        Input.GetButton("right");
    }

    public void leftKey()
    {
        Input.GetButton("left");
    }

    public void downKey()
    {
        player.OnjumpInputDown();
    }

    public void JumpKey()
    {
        player.OnJumpInputUp();
    }
}
