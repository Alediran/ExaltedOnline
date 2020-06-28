export class Charm {
  public Id: Number;
  public Name: String;
  public Essence: Number;
  public TreeTypeId: Number;
  public TypeId: Number;
  public Type: DescriptiveObject;
  public DurationId: Number;
  public Duration: DescriptiveObject;
  public Description: String;
  public IsCustomCharm: Boolean;
  public GameId: Number;

  public CharmCosts: CharmCost[];
  public charmPrerequisites: CharmPrerequisite[];
  public CharmTraits: CharmTrait[];

  // public characterCharms: any[];
  public CharmKeywords: CharmKeyword[];

  constructor() {}
}

//General Structure for descriptive Tables
export class DescriptiveObject {
  public Id: Number;
  public Name: String;
  public Description: String;
}

//Costs to activate the Charm (Essence Motes, Willpower, Health Levels, etc)
export class CharmCost {
  public CostTypes: CharmCostType[];
  public DisplayOrder: Number;
  public Quantity: Number;
}

export class CharmCostType extends DescriptiveObject {
  public DisplayFormat: String;
}

//List all Charms needed to have the Charm
export class CharmPrerequisite {
  public CharmPrerequisites: Charm[];
}

//Necessary Attribute/Ability/Background to purchase and activate the Charm
export class CharmTrait {
  public Trait: Trait;
  public DisplayOrder: Number;
  public AttributeLevel: Number;
}

//Strength, Occultism, Whispers, Breeding
export class Trait {
  public Id: Number;
  public ParentId: Number;
  public Name: String;
  public TraitType: TraitType;
  public Description: String;
}

//Attribute, Ability, Backgrounds, etc
export class TraitType {
  public Id: Number;
  public Name: String;
}

//Keyword List
export class CharmKeyword {
  public Keyword: DescriptiveObject;
  public DisplayOrder: String;
}
