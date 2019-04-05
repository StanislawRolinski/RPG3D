using UnityEngine;

namespace RPG.Core
{
    public class FollowCamere : MonoBehaviour
    {
        [SerializeField] Transform target;

        void LateUpdate()
        {
            transform.position = target.position;
        }
    }
}