using UnityEngine;

public class GoodIExample : MonoBehaviour
{
    public interface IPhysicalSkill
    {
        void PhysicalAttack();
        void UseShield();
    }

    public interface IMagicSkill
    {
        void CastSpell(string spellName);
        void CheckMana();
    }

    public interface ISupportSkill
    {
        void Heal(int amount);
        void ApplyBuff();
    }

    public class Warrior : IPhysicalSkill
    {
        public void PhysicalAttack()
        {
            Debug.Log("Warrior is Attacking");
        }

        public void UseShield()
        {
            Debug.Log("Warrior is using shield");
        }
    }

    public class Mage : IMagicSkill, ISupportSkill 
    {
        public void ApplyBuff()
        {
            Debug.Log("Mage is applying buff");
        }

        public void CastSpell(string spellName)
        {
            Debug.Log("Mage is casting spell");
        }

        public void CheckMana()
        {
            Debug.Log("Mage is checking mana");
        }

        public void Heal(int amount)
        {
            Debug.Log("Mage is using Heal");
        }
    }
}
