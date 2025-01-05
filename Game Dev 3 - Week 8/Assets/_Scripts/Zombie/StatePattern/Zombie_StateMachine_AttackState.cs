using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDevWithMarco.StatePattern
{
    public class Zombie_StateMachine_AttackState : Zombie_StateMachine_BaseState
    {
        public override void EnterState(Zombie_StateMachine_Manager stateMachineManager)
        {
            stateMachineManager.animScript.PlayAttackAnimation();
        }

        public override void UpdateState(Zombie_StateMachine_Manager stateMachineManager)
        {

        }

        public override void OnCollisionEnter(Zombie_StateMachine_Manager stateMachineManager, Collision collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                stateMachineManager.SwitchState(stateMachineManager.attackState);
            }
        }

        public override void OnCollisionExit(Zombie_StateMachine_Manager stateMachineManager, Collision collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                stateMachineManager.SwitchState(stateMachineManager.movingState);
            }
        }

        public override void OnTriggerEnter(Zombie_StateMachine_Manager stateMachineManager, Collider collider)
        {

        }
    }
}