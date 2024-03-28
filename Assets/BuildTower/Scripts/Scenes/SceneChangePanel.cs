namespace BuildTower.Scripts.Scenes
{
    using System;
    using System.Linq;
    using UnityEngine;
    using Cache = BuildTower.Scripts.Helpers.Cache;

    [RequireComponent(typeof(Animator))]
    public class SceneChangePanel : MonoBehaviour
    {
        private readonly Lazy<Animator> _animator;

        public readonly Lazy<float> BlackingLengthInSec;
        public readonly Lazy<float> WhitingLengthInSec;

        public SceneChangePanel()
        {
            _animator = new Lazy<Animator>(GetComponent<Animator>);

            var clips = _animator.Value.runtimeAnimatorController.animationClips;
            WhitingLengthInSec = new Lazy<float>(() => clips.First(x => x.name == "Whiting").length);
            BlackingLengthInSec = new Lazy<float>(() => clips.First(x => x.name == "Blacking").length);
        }

        public void Blacking()
        {
            _animator.Value.SetTrigger(Cache.Blacking);
        }

        public void Whiting()
        {
            _animator.Value.SetTrigger(Cache.Whiting);
        }
    }
}