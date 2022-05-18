using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KeySystem
{
    public class KeyItemController : MonoBehaviour
    {
        [SerializeField] private bool door = false;
        [SerializeField] private bool key = false;

        [SerializeField] private KeyInt _keyInt = null;

        private KeyDoorController doorObject;

        private void Start()
        {
            if (door)
            {
                doorObject = GetComponent<KeyDoorController>();
            }
        }
        public void ObjectInteraction()
        {
            if (door)
            {
                doorObject.PlayAnimation();
            }
            else if (key)
            {
                _keyInt.hasKey = true;
                gameObject.SetActive(false);
            }
        }
    }
}
