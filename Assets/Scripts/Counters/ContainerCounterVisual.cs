using System;
using UnityEngine;

namespace Counters
{
    public class ContainerCounterVisual : MonoBehaviour
    {
        [SerializeField] private ContainerCounter containerCounter;
    
        private Animator _animator;
        private static readonly int OpenClose = Animator.StringToHash(OPEN_CLOSE);
        private const string OPEN_CLOSE = "OpenClose"; // "OpenClose" is a trigger in the Animator that we want to set to true when the player grabs an object from the counter

        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }
    
        private void Start()
        {
            containerCounter.OnPlayerGrabbedObject += ContainerCounter_OnPlayerGrabbedObject;
        }
    
        private void ContainerCounter_OnPlayerGrabbedObject(object sender, EventArgs e)
        {
            _animator.SetTrigger(OpenClose);
        }
    }
}