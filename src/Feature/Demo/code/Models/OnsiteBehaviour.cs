﻿namespace Sitecore.Feature.Demo.Models
{
  using System.Collections;
  using System.Collections.Generic;

  public class OnsiteBehavior
  {
    public IEnumerable<Profile> Profiles { get; set; }
    public IEnumerable<Goal> Goals { get; set; }
    public IEnumerable<Outcome> Outcomes { get; set; }
  }
}