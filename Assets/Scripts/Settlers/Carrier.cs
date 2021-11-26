using System.Collections;
using UnityEngine;

namespace Settlers
{
    /// <summary>
    /// The carrier is responsible for carrying items from one location to another.
    /// </summary>
    public class Carrier : Settler
    {
        /// <summary>
        /// The type/name of this settler.
        /// </summary>
        public new SettlerType settlerName = SettlerType.Carrier;
        
        /// <summary>
        /// The resource that is currently carried by the carrier. Null if no resource is being carried.
        /// </summary>
        /// <remarks>Will be relevant in the future for visuals.</remarks>
        private string CarriedResource { get; set; }
        
        /// <summary>
        /// Main responsibility of a carrier is picking up items from one location and dropping them off at another.
        /// </summary>
        /// <param name="pickUp">The packet from which the item should be picked up.</param>
        /// <param name="dropOff">The packet in which the item should be dropped into.</param>
        /// <returns>IEnumerator: So that the carrier can walk to a position without holding off the whole game.</returns>
        public IEnumerator PickUpAndDeliverItem(ResourcePacket pickUp, ResourcePacket dropOff)
        {
            // pick up an item
            MoveToPosition(pickUp.Position);
            yield return new WaitUntil(() => Nav.remainingDistance < 0.5f);
            TakeResourceFrom(pickUp);
            
            // drop off an item
            MoveToPosition(dropOff.Position);
            yield return new WaitUntil(() => Nav.remainingDistance < 0.5f);
            PlaceResourceInto(dropOff);
        }

        /// <summary>
        /// Take an item from a ResourcePacket.
        /// </summary>
        /// <param name="packet">The packet from which the item should be taken.</param>
        private void TakeResourceFrom(ResourcePacket packet)
        {
            if (packet.ResourceCount > 0)
            {
                packet.ResourceCount -= 1;
                CarriedResource = packet.ResourceType;
            }
            else
            {
                Debug.LogError("There was a problem with picking up an item at " + packet.Position);
            }
        }

        /// <summary>
        /// Place the carried item into a ResourcePacket.
        /// </summary>
        /// <param name="packet">The packet into which the item should be placed.</param>
        private void PlaceResourceInto(ResourcePacket packet)
        {
            if (packet.ResourceCount < packet.MaxResourceCount && packet.ResourceType == CarriedResource)
            {
                packet.ResourceCount += 1;
                CarriedResource = null;
            }
            else
            {
                Debug.LogError("There was a problem with placing down an item at " + packet.Position);
            }
        }
    }
}

