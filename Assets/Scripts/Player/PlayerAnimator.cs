using Farm.Helpers;
using UnityEngine;

namespace Farm.Player
{
    public sealed class PlayerAnimator : MonoBehaviour
    {
        public Animator Animator { get; private set; }

        private void Awake()
        {
            Animator = GetComponentInChildren<Animator>();
        }

        public void PlayWalkAnimation(bool isMoving)
        {
            Animator.SetBool(AnimatorHash.Walking, isMoving);
        }

        public void PlayPlantAnimation()
        {
            Animator.SetTrigger(AnimatorHash.Plant);
        }

        public void PlayPickupAnimation()
        {
            Animator.SetTrigger(AnimatorHash.Pickup);
        }
    }
}