# Inventory

[![.NET](https://github.com/neilpatris/Inventory-kata/actions/workflows/dotnet.yml/badge.svg)](https://github.com/neilpatris/Inventory-kata/actions/workflows/dotnet.yml)

A game inventory written in C# (.NET 10). Identical items stack up to a limit, the bag has a maximum weight, and you can sort, filter and save what you carry.

The goal is to practice generics, structs, records, `virtual` / `override` / `new`, equality, `IEnumerable` with `yield`, LINQ and unit testing with NUnit.

The project is a work in progress, built step by step with one pull request per step.

## Requirements

- .NET 10 SDK

## Running the tests

From the solution folder:

    dotnet test

The tests also run on GitHub Actions at every push.

## Rules

- Every item belongs to one of three categories: weapon, potion or material.
- Identical items go in the same stack, up to 1 per stack for weapons, 10 for potions and 99 for materials.
- The inventory has a maximum weight. If an item doesn't fully fit, only what fits is added.
- Removing more items than the inventory holds removes nothing.
- Each category computes its value its own way: a weapon loses value as it wears out, a potion has a fixed value and a rare material is worth three times its base value.

## Items

    Name            Category    Weight    Base value    Notes
    Sword           Weapon      3 kg      100 gold      Max durability 50
    Axe             Weapon      5 kg      150 gold      Max durability 40
    HealthPotion    Potion      1 kg      20 gold
    ManaPotion      Potion      1 kg      30 gold
    Iron            Material    2 kg      5 gold        Common
    Crystal         Material    1 kg      10 gold       Rare

## Project structure

    Inventory.Core       Game logic: items, stacks and the inventory
    Inventory.Console    Console interface
    Inventory.Tests      NUnit tests for the items and the inventory
