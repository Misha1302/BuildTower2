namespace BuildTower
{
    using System.Linq;
    using UnityEngine;

    [RequireComponent(typeof(Animator))]
    public class SceneChangePanel : MonoBehaviour
    {
        private Animator _animator;

        private Animator Animator => _animator == null ? _animator = GetComponent<Animator>() : _animator;

        public float BlackingLengthInSec =>
            _animator.runtimeAnimatorController.animationClips.First(x => x.name == "Blacking").length;

        public float WhitingLengthInSec =>
            _animator.runtimeAnimatorController.animationClips.First(x => x.name == "Whiting").length;

        public void Blacking()
        {
            Animator.SetTrigger(Cache.Blacking);
        }

        public void Whiting()
        {
            Animator.SetTrigger(Cache.Whiting);
        }
    }
}