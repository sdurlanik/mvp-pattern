using System;
using UnityEngine;

namespace SDurlanik.Mvp
{
    public class SimplePlayerController : MonoBehaviour
    {
        public float speed = 5.0f;

        EventBinding<PlayerAbilityUsedEvent> _playerEventBinding;

        private void OnEnable()
        {
            _playerEventBinding = new EventBinding<PlayerAbilityUsedEvent>(HandleOnAbilityUsed);
            EventBus<PlayerAbilityUsedEvent>.Register(_playerEventBinding);
        }

        private void HandleOnAbilityUsed(PlayerAbilityUsedEvent ability)
        {
            Debug.Log(ability.ToString());
        }

        private void OnDisable()
        {
            EventBus<PlayerAbilityUsedEvent>.Deregister(_playerEventBinding);
        }


        public void Update()
        {
            Move();
        }

        private void Move()
        {
            float vertical = Input.GetAxis("Vertical");
            float horizontal = Input.GetAxis("Horizontal");

            Vector3 movement = new Vector3(horizontal, 0, vertical);
            transform.Translate(movement * speed * Time.deltaTime);
        }
    }
}