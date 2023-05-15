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

        void Start()
        {
            // Lance une coroutine qui attend 5 secondes avant de changer la valeur du booléen
            StartCoroutine(ChangeBoolAfterDelay(player));
        }

        private void StartCoroutine(IEnumerator enumerator)
        {
            throw new NotImplementedException();
        }

        private IEnumerator ChangeBoolAfterDelay(PlayerController player)
        {
            yield return new WaitForSeconds(5f); // attend 5 secondes

            isSpeedBoosted = false; // change la valeur du booléen
            player.SpeedMultiplier = 2;
        }
    }
}