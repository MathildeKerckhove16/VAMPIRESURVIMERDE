using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gameplay.Weapons
{

    /// <summary>
    /// Represents a lasso with a large AOE
    /// </summary>
    public class WeaponCatNip : WeaponBase
    {

        [SerializeField] GameObject _prefab;
        bool isSpeedBoosted = true;
        public PlayerController player;
        public float boostDuration = 5.0f;

        public WeaponCatNip()
        {
        }

        public override void Update(PlayerController player)
        {
            if(isSpeedBoosted==true)
            {
                player.SpeedMultiplier = 10;
            }
            

        }

        public void ActivateSpeedBoost()
        {
            if (!isSpeedBoosted)
            {
                isSpeedBoosted = true;
                StartCoroutine(DisableSpeedBoost());
            }
        }

        private void StartCoroutine(IEnumerator enumerator)
        {
            throw new NotImplementedException();
        }

        // Désactive l'effet de vitesse boostée après la durée spécifiée
        private IEnumerator DisableSpeedBoost()
        {
            yield return new WaitForSeconds(boostDuration);
            isSpeedBoosted = false;
        }
    }
}