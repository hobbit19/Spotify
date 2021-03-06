﻿namespace Spotify.ApiModelExtensions
{
  using System.Collections.Generic;

  using SpotifyWebApi.Model;

  /// <summary>The equality comparer for the device model.</summary>
  public sealed class DeviceEqualityComparer : IEqualityComparer<Device>
  {
    #region Methods

    /// <summary>Checks whether the two models equal each other.</summary>
    /// <param name="x">The first model.</param>
    /// <param name="y">The second model.</param>
    /// <returns>Whether the two models equal each other.</returns>
    public bool Equals(Device x, Device y)
    {
      if (object.ReferenceEquals(x, y))
      {
        return true;
      }

      if (object.ReferenceEquals(x, null))
      {
        return false;
      }

      if (object.ReferenceEquals(y, null))
      {
        return false;
      }

      if (x.GetType() != y.GetType())
      {
        return false;
      }

      return string.Equals(x.Id, y.Id) && x.IsActive == y.IsActive && x.IsRestricted == y.IsRestricted && string.Equals(x.Name, y.Name) && string.Equals(x.Type, y.Type) && x.VolumePercent == y.VolumePercent;
    }

    /// <summary>Gets the hash code for the model.</summary>
    /// <param name="obj">The model.</param>
    /// <returns>The hash code.</returns>
    public int GetHashCode(Device obj)
    {
      unchecked
      {
        var hashCode = obj.Id != null ? obj.Id.GetHashCode() : 0;
        hashCode = (hashCode * 397) ^ obj.IsActive.GetHashCode();
        hashCode = (hashCode * 397) ^ obj.IsRestricted.GetHashCode();
        hashCode = (hashCode * 397) ^ (obj.Name != null ? obj.Name.GetHashCode() : 0);
        hashCode = (hashCode * 397) ^ (obj.Type != null ? obj.Type.GetHashCode() : 0);
        hashCode = (hashCode * 397) ^ obj.VolumePercent.GetHashCode();
        return hashCode;
      }
    }

    #endregion
  }
}