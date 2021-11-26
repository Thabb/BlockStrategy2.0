using UnityEngine;
using UnityEngine.Android;

/// <summary>
/// This is a utility class, that manages stacks of items.
/// </summary>
public class ResourcePacket
{
    /// <summary>
    /// An enum to contain all of the different resources.
    /// </summary>
    public enum Resource
    {
        None,
        Log,
        Plank
    }
    
    /// <summary>
    /// Amount of resources currently inside the packet.
    /// </summary>
    public int ResourceCount { get; set; }
    /// <summary>
    /// Max amount of resources able to be stored inside the packet.
    /// </summary>
    public int MaxResourceCount { get; set; }
    /// <summary>
    /// The type of resource the packet can store (f.e. "log" or "stone").
    /// </summary>
    public Resource ResourceType { get; set; }
    /// <summary>
    /// The position of the packet.
    /// </summary>
    public Vector3 Position { get; set; }

    /// <summary>
    /// A resource packet shouldn't be able to be initialised without giving some properties. 
    /// </summary>
    /// <param name="type">The type of resource the packet should store.</param>
    /// <param name="max">The maximum amount of resources the packet should be able to store.</param>
    /// <param name="position">The position of the packet. This is mostly dependent on the Building the packet is attached to.</param>
    public ResourcePacket(Resource type, int max, Vector3 position)
    {
        ResourceType = type;
        MaxResourceCount = max;
        Position = position;
    }
}
