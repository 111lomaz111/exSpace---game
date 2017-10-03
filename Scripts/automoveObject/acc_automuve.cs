using System;
using UnityEngine;

//it`s for accelerating automovement of objects

public class acc_automuve : MonoBehaviour
    {
        public Vector3andSpace moveUnitsPerSecond;
        public Vector3andSpace rotateDegreesPerSecond;
        public float predkosc = 1; //means speed
        public float wzrost_acc = 1F; // means growth of accelerate
        public float dodanie_czasu = 2F; // add time 
        private float m_LastRealTime;
        public float Ready;

        private void Start()
        {
            m_LastRealTime = Time.realtimeSinceStartup;
        }

        private void Update()
        {
            float deltaTime = Time.deltaTime;
            {
                deltaTime = (Time.realtimeSinceStartup - m_LastRealTime);
                m_LastRealTime = Time.realtimeSinceStartup;                
            }
            transform.Translate(moveUnitsPerSecond.value*deltaTime* predkosc, moveUnitsPerSecond.space);
            transform.Rotate(rotateDegreesPerSecond.value*deltaTime, moveUnitsPerSecond.space);
            if (Ready <= 0)
            {
                predkosc += wzrost_acc;
                Ready = dodanie_czasu;
            }
        Ready -= Time.deltaTime;
        }
        

        [Serializable]
        public class Vector3andSpace
        {
            public Vector3 value;
            public Space space = Space.Self;
        }
    }