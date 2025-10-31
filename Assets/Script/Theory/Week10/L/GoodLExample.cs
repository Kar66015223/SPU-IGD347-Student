using System;
using UnityEngine;

public class GoodLExample : MonoBehaviour
{
    public class Animal // คลาสพื้นฐานสำหรับสัตว์
    {
        public virtual void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    public class Bird : Animal
    {
        public virtual void LayEggs()
        {
            Debug.Log("Bird can lay eggs.");
        }
    }

    public interface IFlyable
    {
        void Fly();
    }

    public class Sparrow : Bird, IFlyable
    {
        public void Fly()
        {
            Debug.Log("Sparrow can fly.");
        }
    }

    public class Ostrich : Bird
    {
        public void Run()
        {
            Debug.Log("Ostrich can run.");
        }
    }
}