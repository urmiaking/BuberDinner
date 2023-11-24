﻿using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Menu.ValueObjects;

namespace BuberDinner.Domain.Menu.Entities;

public class MenuItem : Entity<MenuItemId>
{
    public MenuItem(MenuItemId id, string name, string description) : base(id)
    {
        Name = name;
        Description = description;
    }

    public string Name { get; }
    public string Description { get; }

    public static MenuItem Create(string name, string description)
    {
        return new(MenuItemId.CreateUnique(), name, description);
    }
}
