using System;

class MainClass {
  public static void Main (string[] args) {
    var nameOne = CitizenGenerator.Generate();
    var randomFaction = FactionGenerator.RandomFaction();
    
    var nameTwo = CitizenGenerator.Generate();
    var secondRandomFaction = FactionGenerator.RandomFaction();
    
    var nameThree = CitizenGenerator.Generate();
    var thirdRandomFaction = FactionGenerator.RandomFaction();

    Console.WriteLine($"Faction 1: {randomFaction}.
    
    Profile: {randomFaction.Description}

    Contact: {nameOne}
    ");

    Console.WriteLine($"Faction 2: {secondRandomFaction}.
    
    Profile: {secondRandomFaction.Description}

    Contact: {nameTwo}
    ");


    Console.WriteLine($"Faction 3: {thirdRandomFaction}.
    
    Profile: {thirdRandomFaction.Description}

    Contact: {nameThree}
    ");


    Console.WriteLine("The Plot:");

    Console.WriteLine(Plot.Generate(randomFaction, secondRandomFaction,thirdRandomFaction));
  }
}