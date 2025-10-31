using System;
using UnityEngine;
using UnityEngine.VFX;

namespace Theory.Week10
{
    public class GoodDExample : MonoBehaviour
    {
        private Enemy _enemy;

        public GoodDExample(Enemy enemy)
        {
            _enemy = enemy;
        }

        public void StartWave()
        {
            _enemy.Spawn();
            _enemy.PerformAction();
        }
    }

    public class Enemy : MonoBehaviour
    {
        public void Spawn()
        {

        }

        public void PerformAction()
        {

        }
    }
}