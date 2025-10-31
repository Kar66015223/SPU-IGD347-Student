using Theory.Week10;
using UnityEngine;


public class UseWeapon : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("---- Bad Calculate Damage ----");
        Weapon sword = new Weapon(WeaponType.Sword, 10);
        Debug.Log($"Sword Damage: {GoodCalculateDamage(sword)}"); // Output: Sword Damage: 15

    }
    public int GoodCalculateDamage(IBonusWeapon weapon)
    {
        int damage = weapon.GetDamage();
        return damage;
    }

    public int BadCalculateDamage(Weapon weapon)
    {
        int totalDamage = weapon.BaseDamage;
        if (weapon.Type == WeaponType.Sword)
        {
            totalDamage += 5; // ⺹�ʴҺ
        }
        else if (weapon.Type == WeaponType.Bow)
        {
            totalDamage += 3; // ⺹�ʸ��
        }
        else if (weapon.Type == WeaponType.Gun)
        {
            totalDamage += 10; // ⺹�ʻ׹
        }
        else if(weapon.Type == WeaponType.Axe)
        {
            totalDamage += 25;
        }
        // ������� WeaponType.Axe ��ͧ������ else if �ç���
        return totalDamage;
    }
    
}
