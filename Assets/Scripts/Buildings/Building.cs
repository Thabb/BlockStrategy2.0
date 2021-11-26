using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Buildings
{
    /// <summary>
    /// An enum to save all the different types of buildings in.
    /// </summary>
    public enum BuildingType
    {
        Container,
        Woodcutter
    }
    
    /// <summary>
    /// The base class for every kind of building. Shouldn't be instantiated on its own.
    /// </summary>
    public abstract class Building : MonoBehaviour
    {
        /// <summary>
        /// The type/name of this building.
        /// </summary>
        public abstract BuildingType BuildingName { get; set; }
        
        /// <summary>
        /// A list of ResourcePackets that are used for the Production. This will need to be instantiated by the Start method of every child with the specific resources of that building.
        /// </summary>
        protected List<ResourcePacket> Input { get; set; }
        /// <summary>
        /// A list of ResourcePackets that are the product of the Production. This will need to be instantiated by the Start method of every child with the specific resources of that building.
        /// </summary>
        protected List<ResourcePacket> Output { get; set; }
        /// <summary>
        /// Starts the Production Coroutine.
        /// </summary>
        protected void Start()
        {
            StartCoroutine(Production());
        }

        /// <summary>
        /// This method takes resources from the input and places some resources in the output instead. This will be different for every child.
        /// </summary>
        /// <returns>IEnumerator: Production of a building should always run and not hinder the game by it.</returns>
        protected abstract IEnumerator Production();
    }
}