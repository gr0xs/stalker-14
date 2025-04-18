using Content.Server.Radiation.Systems;
using Content.Shared.Radiation.Components;

namespace Content.Server.Radiation.Components;

/// <summary>
///     Marks component that receive radiation from <see cref="RadiationSourceComponent"/>.
/// </summary>
[RegisterComponent]
[Access([typeof(RadiationSystem), typeof(GeigerSystem)])] // stalker-changes
public sealed partial class RadiationReceiverComponent : Component
{
    /// <summary>
    ///     Current radiation value in rads per second.
    ///     Periodically updated by radiation system.
    /// </summary>
    [ViewVariables(VVAccess.ReadOnly)]
    public Dictionary<string, float> CurrentDamage = new(); // stalker-changes
}

