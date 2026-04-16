
using UnityEngine;


public class MovementDisabler : StateMachineBehaviour
{
    private WeaponManager weaponmanager;


    public enum Option { Enable, Disable }
    public Option enableMovement;


    override public void OnStateEnter(
        Animator animator,
        AnimatorStateInfo stateInfo,
        int layerIndex)
    {
        weaponmanager = animator.GetComponent<WeaponManager>();


        if (enableMovement == Option.Enable)
            weaponmanager.EnableMovement(true);
        else
            weaponmanager.EnableMovement(false);
    }
}

