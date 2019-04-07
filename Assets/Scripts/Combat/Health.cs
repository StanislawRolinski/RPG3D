using UnityEngine;

namespace RPG.Combat
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
                if (!IsDead)
                {
                    GetComponent<Animator>().SetTrigger("die");
                    IsDead = true;
                }
            }
            print(healthPoints);
        }
    }
}