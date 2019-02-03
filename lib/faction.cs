using System;
using System.Collections.Generic;

public class Faction
{
  public string Name;
  public string Description;
  public string Leader;

  public override string ToString() => Name;
}

public static class FactionGenerator
{
  static Faction factionA = new Faction
  {
    Name = "Gatzmann Society",
    Description = "A pro-Old Reckoning preservation society that seeks to establish antique collections and interpret the Gatzmann Archives (the major existing source of knowledge about the OR). Generally motiviated by emotions and sentimental values over practicality.",
    Leader = "Charles-U-AXU"
  };

  static Faction factionB = new Faction
  {
    Name = "Epicureans",
    Description = "An alliance of hedonistic Ultraviolets, intent on acquiring as much pleasure as possible and abusing their position as leaders of Alpha Complex for their own petty desires. Fine food, harems, drugs; all of these are in the average Epicurean lifestyle. They are focused on fufilling their decadent lifestyles think the other Cliques are taking life *way* too seriously.",
    Leader = "Esquire-U-MNC"
  };

  static Faction factionC = new Faction
  {
    Name = "Tillinghast’s",
    Description = "The 'old guard' that defined the civic traditions of Alpha Complex's elite, regulating the behavior of ULTRAVIOLETs to promote decency, self-respect, and cultural refinement. Easily the most powerful clique in the Complex, boasting several influential and powerful members. They are currently focused on defending the status quo.",
    Leader = "Cecil-U-GUD"
  };

  static Faction factionD = new Faction
  {
    Name = "Reform Party",
    Description = "An union of 'genuine social reformers inspired by Humanist rhetoric' and 'ambitious youngsters who conspire to overthrow the entrenched ruling class and take over'. They call themselves the “loyal opposition”, and are the oldest extant Clique in Alpha Complex. They are currently seeking to overthrow the status quo.",
    Leader = "Emily-U-WCD"
  };

  static Faction factionE = new Faction
  {
    Name = "The Gang",
    Description = "A clique that believes in  'radical transformation' - creating a hivemind that can coordinate their actions efficiently to better solve Alpha Complex's many problems. They conduct legal and illegal experiments with mind control, cybernetic augmentation, and AGI. Generally motivated by reason as opposed to concerns about free will and petty emotions.",
    Leader = "Ander-U-MAC"
  };

  static Faction factionF = new Faction
  {
    Name = "Bug Hunters",
    Description = "ULTRAVIOLETs who take their job of programming The Computer and fixing its many bugs a bit *too* seriously, following in the footsteps of JCN (a mega-corporation that was rumored to have built Alpha Complex and The Computer) and the original High Programmer, Gelber-Prime. Currently hunting down the ‘Gelber Open Issue List’, a list that declares all the open bugs in The Computer. They tend to provide 'support' for the other Cliques in Alpha Complex, helping them with their various bug fixes.",
    Leader = "Adam-U-NCH"
  };

  static Faction factionG = new Faction
  {
    Name = "Complex Laser Association",
    Description = "Paranoid citizens and their cronies who believe (rightly?) that the entire Complex has been subverted by traitors. They aim to make Alpha Complex 'loyal' by conducting a Grand Purge, even if said Grand Purge means exterminating 99% of all citizens in Alpha Complex. They tend to be the Complex's 'moral guardians', for lack of a better word.",
    Leader = "Stella-U-DNT"
  };

  static Faction factionH = new Faction
  {
    Name = "The Interperters",
    Description = "Freethinkers who are inspired by Sierra Club rhetoric to focus on expanding Alpha Complex into the Outdoors. Their rhetoric claims to be about 'enlightening the savages', but really it's all about gaining more power and supplies to better fight against all the other cliques. They tend to have a skeptical eye towards the other cliques' isolationistic policies.",
    Leader = "Taij-U-YAP"
  };

  static Faction factionI = new Faction
  {
    Name = "The Inner Party",
    Description = "Sadists who believe that the purpose of absolute power is to be able to torture other citizens without impunity. Their goal is to make Alpha Complex as dystopian and miserable as possible, sometimes even funding rebel movements so that they can have fun cracking down on them later. Their almost-fanatical dedication to their cause alienates them from other ULTRAVIOLETs, who share a bit more empathy with the masses.",
    Leader = "George-U-ORW"
  };

  static Faction factionJ = new Faction
  {
    Name = "VEM",
    Description = "The Voluntary Extiniction Movement believes in a world without any sapients (humans, machines, or computers), believing that it is better to choose oblivion than to let sapients live in a shallow grave like Alpha Complex. Most members aim for causing a gradual death through sabotage of the cloning vats, though a few extremists have also considered using anti-matter WMDs and bioweapons. Despite how sympatethic their propaganda may be, most ULTRAVIOLETs tend to prefer breathing more.",
    Leader = "Sarah-U-KNG"
  };

  static Faction factionK = new Faction
  {
    Name = "The Collaborators",
    Description = "These traitors have sold themselves out to another Complex, under the impression that Complex's Computer might be saner than our Complex's Computer. (Is it? Who knows?) They are attempting to covertly subvert this Complex and incorporate it into the for the glory of the other Complex. The other ULTRAVIOLETs don't really like this clique, as they don't really like losing their political power to outsiders.",
    Leader = "Ariane-U-OPA"
  };

  public static Func<Faction> RandomFaction = Generator.GenerateUniqueRule<Faction>
  (new List<Faction>
  {
    factionA,
    factionB,
    factionC,
    factionD,
    factionE,
    factionF,
    factionG,
    factionH,
    factionI,
    factionJ,
    factionK
  });
}