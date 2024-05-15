using System;
using System.Collections.Generic;
using UnityEngine;

namespace SDurlanik.Mvp
{
    public class AbilityView : MonoBehaviour
    {
        [SerializeField] public AbilityButton[] buttons;

        readonly KeyCode[] keys = { KeyCode.Alpha1, KeyCode.Alpha2, KeyCode.Alpha3, KeyCode.Alpha4, KeyCode.Alpha5 };

        void Awake()
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                if (i >= keys.Length)
                {
                    Debug.LogError("Not enough keycodes for the number of buttons.");
                    break;
                }

                buttons[i].Initialize(i, keys[i]);

                UpdateRadial(0);
            }
        }

        public void UpdateRadial(float progress)
        {
            if (float.IsNaN(progress))
            {
                progress = 0;
            }

            Array.ForEach(buttons, button => button.UpdateRadialFill(progress));
        }

        public void UpdateButtonSprites(IList<Ability> abilities)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                if (i < abilities.Count)
                {
                    buttons[i].UpdateButtonSprite(abilities[i].data.icon);
                }
                else
                {
                    buttons[i].gameObject.SetActive(false);
                }
            }
        }
    }
}