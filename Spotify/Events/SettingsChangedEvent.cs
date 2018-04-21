﻿namespace Spotify.Events
{
  using Prism.Events;

  using Spotify.Data;

  internal class SettingsChangedEvent : PubSubEvent<SettingsData>
  {
  }
}