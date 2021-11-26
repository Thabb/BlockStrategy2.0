using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Buildings
{
    /// <summary>
    /// The woodcutter gets logs delivered and transforms them into wooden planks that are one of the main building resources.
    /// </summary>
    public class WoodcutterBuilding : Building
    {
        /// <summary>
        /// The type/name of this building.
        /// </summary>
        public override BuildingType BuildingName { get; set; } = BuildingType.Woodcutter;

        /// <summary>
        /// Initialises the Input and Output lists.
        /// </summary>
        private new void Start()
        {
            base.Start();
            Input = new List<ResourcePacket>() { new ResourcePacket(ResourcePacket.Resource.Log, 8, transform.position) }; // TODO: Change transform.position to a position that is slightly offset from the building position
            Output = new List<ResourcePacket>() {new ResourcePacket(ResourcePacket.Resource.Plank, 8, transform.position)}; // TODO: Change transform.position to a position that is slightly offset from the building position
        }

        /// <summary>
        /// Every five seconds a log (if there is one) is taken from the input and transformed into a plank.
        /// </summary>
        /// <returns>IEnumerator: Production of a building should always run and not hinder the game by it.</returns>
        protected override IEnumerator Production()
        {
            while (gameObject)
            {
                if (Input[0].ResourceCount > 0)
                {
                    Input[0].ResourceCount -= 1;
                    Output[0].ResourceCount += 1;
                    yield return new WaitForSeconds(5);
                }
            }
        }
    }
}