using System;
using UnityEngine;

public class GoodLExample : MonoBehaviour
{
    public class Animal // ���ʾ�鹰ҹ����Ѻ�ѵ��
    {
        public virtual void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }


   
}
