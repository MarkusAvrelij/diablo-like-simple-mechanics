﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
public class Item 
{
    public enum ItemTypes { weapon, Consumable, Quest}
    public List<BaseStat> Stats { get; set; }
    public string ObjectSlug { get; set; }
    public string Description { get; set; }
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public ItemTypes ItemType { get; set; }
    public string ActionName { get; set; }
    public string ItemName { get; set; }
    public bool ItemModifier { get; set; }

    public Item(List<BaseStat> _Stats, string _OBjectSlug)
    {
        this.Stats = _Stats;
        this.ObjectSlug = _OBjectSlug;
    }
    [Newtonsoft.Json.JsonConstructor]
    public Item(List<BaseStat> _Stats, string _OBjectSlug, string _Description, ItemTypes _ItemType, string _ActionName, string _ItemName, bool _ItemModifier)
    {
        this.Stats = _Stats;
        this.ObjectSlug = _OBjectSlug;
        this.Description = _Description;
        this.ItemType = _ItemType;
        this.ActionName = _ActionName;
        this.ItemName = _ItemName;
        this.ItemModifier = _ItemModifier;
    }
}
