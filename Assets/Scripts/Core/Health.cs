using UnityEngine;

namespace RPG.Core
{
    public class Health : MonoBehaviour
    {
        [SerializeField] float healthPoints = 100f;
        bool isDead = false;

        public bool IsDead { get => isDead; set => isDead = value; }

        public void TakeDamage(float damage)
        {
            healthPoints = Mathf.Max(healthPoints - damage, 0);
            if(healthPoints == 0)
            {
                Die();
            }
        }

        private void Die()
        {
            if (!IsDead)
            {
                GetComponent<Animator>().SetTrigger("die");
                IsDead = true;
                GetComponent<ActionScheduler>().CancelCurrentAction();
            }
        }
    }
}