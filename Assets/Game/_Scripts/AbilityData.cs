using UnityEngine;

namespace SDurlanik.Mvp
{
    [CreateAssetMenu(fileName = "AbilityData", menuName = "ScriptableObjects/AbilityData", order = 1)]
    public class AbilityData : ScriptableObject
    {
        public float duration;
        public Sprite icon;
        public string fullName;
    }
}