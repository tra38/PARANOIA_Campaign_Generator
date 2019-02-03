using System;
using System.Collections.Generic;

public static class Plot
{
  static public readonly string HiddenBase = "{0} currently rules the strategic sector of {3} with an iron fist, but {1} was able to successfully build a secret base, by which they launch periodic attacks. {1} is also receiving temporary aid from {2}, who wants to use the periodic raids as a way to weaken {0}. {0} is now resorting to desperate measures to restore order in {3}, and have issued a mission alert for Troubleshooters.";

  static public readonly string BetterLateThanNever = "{0} used to rule the strategic sector of {3} with an iron fist. However, {1} successfully conducted a terrorist attack in {3}, utterly destroying the sector. {0} wants revenge, and have issued a mission alert for Troubleshooters. {2}, meanwhile, is trying to launch their own attack on {3}, hoping to take over the sector and rebuild it in their own image.";

  static public readonly string BreakingAndEntering = "{0} currently rules the strategic sector of {3} and boasts ownership of numerous WMDs. However, both {1} and {2} plan on stealing the WMDs for themselves. They have each issued their own mission alert for Troubleshooters, asking them to 'liberate' some valuable equipment.";

  static public readonly string DelverDelight = "{0} have just discovered the existence of a secret passageway to the Underplex/Outdoors within the strategic sector of {3}. {0} already secured the treasure-laden ruins with their own military troops. However, {1} and {2} got wind of this secret passageway and want to also loot the ruins for themselves. They have each issued their own mission alert for Troubleshooters.";

  static public readonly string Elementary = "A high-ranking official working for {0} was assassinated in the strategic sector of {3}. {0} blames {1} for the attack and is preparing to conduct retaliatory assassinations. However, {1} claims to be 'innocent', and that they are being framed by {2} (who secretly wants a war between {0} and {1}). To clear their name, {1} took the drastic step of issuing a mission alert for Troubleshooters.";

  static public readonly string ScoreOneForHomeTeam = "Every year, a few eccentric High Programming cliques particpate in the Tournament - 'a complex, dangerous contest that is completely hidden from The Computer (they hope)'. The winner of the Tournament gain huge prestige within the elite circles of ULTRAVIOLET High Society, which can be used to help secure more political power. The latest verison of the Tournament involve pitting Troubleshooter teams against each other in semi-covert gladiator matches disguised as routine Troubleshooting missions in {3}. {0} is the reigning champion Clique, but {1} and {2} are also big contenders and are willing to do whatever it takes to win the gold.";

  public static string Generate(string template, Faction protagonist, Faction antagonist, Faction wildcard) => string.Format(template, protagonist.Name, antagonist.Name, wildcard.Name, SectorGenerator.Generate() );

  public static string Generate(Faction protagonist, Faction antagonist, Faction wildcard)
  {
    var template = RandomTemplate();
    return Generate(template, protagonist, antagonist, wildcard);
  }

  public static Func<string> RandomTemplate = Generator.GenerateRule<string>(
  new List<string>() {
    HiddenBase,
    BetterLateThanNever,
    BreakingAndEntering,
    DelverDelight,
    Elementary,
    ScoreOneForHomeTeam
  });

}

/*
public static class PlotGenerator
{
  static Plot hiddenBase = new Plot
  {
    Template = "{0} currently rules the strategic sector of {3} with an iron fist, but {1} was able to successfully build a secret base, by which they launch periodic attacks. {1} is also receiving temporary aid from {2}, who wants to use the periodic raids as a way to weaken {0}. {0} is now resorting to desperate measures to restore order in {3}, and have issued a mission alert for Troubleshooters."
  };

  static Plot betterLateThanNever = new Plot
  {
    Template = "{0} used to rule the strategic sector of {3} with an iron fist. However, {1} successfully conducted a terrorist attack in {3}, utterly destroying the sector. {0} wants revenge, and have issued a mission alert for Troubleshooters. {2}, meanwhile, is trying to launch their own attack on {3}, hoping to take over the sector and rebuild it in their own image."
  };

  static Plot breakingAndEntering = new Plot
  {
    Template = "{0} currently rules the strategic sector of {3} and boasts ownership of numerous WMDs. However, both {1} and {2} plan on stealing the WMDs for themselves. They have each issued their own mission alert for Troubleshooters, asking them to 'liberate' some valuable equipment."
  };

  static Plot delverDelight = new Plot
  {
    Template = "{0} have just discovered the existence of a secret passageway to the Underplex/Outdoors within the strategic sector of {3}. {0} already secured the treasure-laden ruins with their own military troops. However, {1} and {2} got wind of this secret passageway and want to also loot the ruins for themselves. They have each issued their own mission alert for Troubleshooters."
  };

  static Plot elementary = new Plot
  {
    Template = "A high-ranking official working for {0} was assassinated in the strategic sector of {3}. {0} blames {1} for the attack and is preparing to conduct retaliatory assassinations. However, {1} claims to be 'innocent', and that they are being framed by {2} (who secretly wants a war between {0} and {1}). To clear their name, {1} took the drastic step of issuing a mission alert for Troubleshooters."
  };

  //Idea came from "Vapors Don’t Shoot Back"
  static Plot scoreOneForHomeTeam = new Plot
  {
    Template = "Every year, a few eccentric High Programming cliques particpate in the Tournament - 'a complex, dangerous contest that is completely hidden from The Computer (they hope)'. The winner of the Tournament gain huge prestige within the elite circles of ULTRAVIOLET High Society, which can be used to help secure more political power. The latest verison of the Tournament involve pitting Troubleshooter teams against each other in semi-covert gladiator matches disguised as routine Troubleshooting missions in {3}. {0} is the reigning champion Clique, but {1} and {2} are also big contenders and are willing to do whatever it takes to win the gold."
  };
  
  public static Func<Plot> RandomPlot = Generator.GenerateRule<Plot>(
    new List<Plot>()
    {
      hiddenBase,
      betterLateThanNever,
      breakingAndEntering,
      delverDelight,
      elementary,
      scoreOneForHomeTeam
    }
  );

  public static string Generate(Faction protagonist, Faction antagonist, Faction wildcard)
  {
    Plot plot = RandomPlot();
    return plot.Generate(protagonist, antagonist, wildcard);
  }

}
*/