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

## Design decisions

Each category calculates its value differently, so I created an `Item` class with three child classes: `Weapon`, `Material`, and `Potion`. `Weapon` and `Material` use `override` to calculate their own value. `Potion` doesn't need it because its value is just the base value.

A `Sword` and an `Axe` are not separate classes because they use the same formula, only the numbers are different. For rarity, the `Rarity` enum only tells if a material is common or rare. The `Material` class decides that rare materials are worth 3 times more.

I used `record` for items because I consider two items equal when all their data is the same. A record handles this comparison automatically.

Weight is a `readonly struct` because it's a small value that is often added together and doesn't change after being created.

I used `new` on `Describe()` on purpose. It's just to demonstrate how it works, not because the project really needs it.
