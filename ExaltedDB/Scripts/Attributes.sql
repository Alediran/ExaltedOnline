print 'Inserting Seed data for table AttributeTypes'

INSERT dbo.AttributeTypes select 1, 'Attribute'
where not exists (select 1 from dbo.Attributes where Id = 1)

INSERT dbo.AttributeTypes select 2, 'Abilities'
where not exists (select 1 from dbo.Attributes where Id = 2)

INSERT dbo.AttributeTypes select 3, 'Merit'
where not exists (select 1 from dbo.Attributes where Id = 3)

INSERT dbo.AttributeTypes select 4, 'Flaw'
where not exists (select 1 from dbo.Attributes where Id = 4)



print 'Inserting Seed data for table Attributes'

--Character Attributes
INSERT dbo.Attributes select 1, 'Strength', 1, 'Strength represents a character’s raw physical power, the sheer might of what he can achieve by muscle alone. In combat, Strength helps determine the damage a character can deal with his withering attacks, as well as how well he grapples foes. It’s also used when a character wishes to lift, break, or heave any objects or obstacles that might stand in his way.'
where not exists (select 1 from dbo.Attributes where Id = 1)

INSERT dbo.Attributes select 2, 'Dexterity', 1, 'Dexterity is grace, agility, and coordination. In combat, Dexterity determines both the accuracy of a character’s attacks and his faculty to defend against enemy attacks, as well as being used for movement that relies on swift or nimble maneuvering across terrain. It’s also used for actions that require precise control of physical motions, such as hiding from a patrolling sentry or picking a merchant prince’s pocket.'
where not exists (select 1 from dbo.Attributes where Id = 2)

INSERT dbo.Attributes select 3, 'Stamina', 1, 'Stamina is a measure of vitality. In combat, having a high Stamina rating reduces the damage of withering attacks. It’s also used to fight off poison or disease, and more generally to endure the effects of anything that might weaken or assail the body, be it lengthy physical exertion, sleep deprivation, suffocation, exposure to the elements, or starvation.'
where not exists (select 1 from dbo.Attributes where Id = 3)

INSERT dbo.Attributes select 4, 'Charisma', 1, 'Charisma represents a character’s ability to express and articulate his beliefs or commands, convincing others to see things his way or follow his orders. It’s used primarily in social influence when a character wishes to make a sincere argument that he genuinely believes in, but can also be used in combat to lead armies from the front with rallying, inspiring speeches.'
where not exists (select 1 from dbo.Attributes where Id = 4)

INSERT dbo.Attributes select 5, 'Manipulation', 1, 'Manipulation is a character’s innate talent for deception, passing off lies as the truth, or simply telling people what he knows they want to hear. It’s used primarily in social influence when a character wishes to make a false argument, whether through outright lying or more complicated verbal misdirection, as well as any argument where the character is purely trying to evoke a desired response rather than to express his own feelings or outlook. It also represents a character’s ability to remain composed and not reveal his true feelings, contributing to his Guile rating.'
where not exists (select 1 from dbo.Attributes where Id = 5)

INSERT dbo.Attributes select 6, 'Appearance', 1, 'Appearance is a measure of a character’s striking looks and his ability to use them. Generally, this means a measure of how attractive the character is, but for certain characters (see the Hideous merit, p. 162), Appearance measures how intimidatingly unpleasant the character’s looks are. Appearance is used when a character wishes to influence others through looks, beauty, overwhelming presence, or first impressions rather than reasoned debate or emotional manipulation.'
where not exists (select 1 from dbo.Attributes where Id = 6)

INSERT dbo.Attributes select 7, 'Perception', 1, 'Perception rates both the raw quality of a character’s senses and his faculty for comprehending what he perceives. Perception is used for noticing details, whether it is a strange plume of smoke over a far-off village, a black-clad assassin lying in wait, a subtle tell in a courtier’s manner of speech, or a fragmentary clue at the scene of a crime.'
where not exists (select 1 from dbo.Attributes where Id = 7)

INSERT dbo.Attributes select 8, 'Intelligence', 1, 'Intelligence measures a character’s ability to think logically and rationally. It covers analytical thinking, drawing connections between disparate pieces of information, recalling pieces of knowledge or useful memories at opportune moments, and making judgments based on rigid logic. It is the province of strategoi, sorcerers, and savants.'
where not exists (select 1 from dbo.Attributes where Id = 8)

INSERT dbo.Attributes select 9, 'Wits', 1, 'Wits rates a character’s intuition, common sense, and ability to react quickly to new circumstances or while under fire. In combat, Wits is used for the Join Battle roll that determines a character’s starting Initiative, and it also factors into a character’s capacity to remain unmoved by persuasion that goes against his intuitive understanding of the world, contributing to his Resolve rating.'
where not exists (select 1 from dbo.Attributes where Id = 9)

--Character Abilities
INSERT dbo.Attributes select 10, 'Archery', 2, '<b>This Ability is important in combat.</b><br/> Archery is the discipline of using ranged weapons. The bow is the dominant form of ranged weapon in Creation in all its different varieties, from the simple wooden self bows used by subsistence hunters to the composite bows carried by the Realm’s archers. However, Archery also applies to the use of more exotic weapons. In the South, weapons fueled by a reagent called firedust shoot streamers of flame rather than arrows, and in the North, the nation-states of the Haslanti League favor the crossbow.'
where not exists (select 1 from dbo.Attributes where Id = 10)

INSERT dbo.Attributes select 11, 'Athletics', 2, '<b>This Ability is important in combat.</b><br/> Athletics is the discipline of physical fitness and acrobatic maneuverability. It is used in performing feats of strength, such as lifting up a fallen cart or bending the metal bars of a prison cage. It is also used for movement both in and out of combat—racing towards a distant enemy, jumping over a gaping chasm, climbing a brick wall, and swimming against a powerful tide are all uses of Athletics.'
where not exists (select 1 from dbo.Attributes where Id = 11)

INSERT dbo.Attributes select 12, 'Awareness', 2, '<b>This Ability is important in combat.</b><br/> Awareness is the practiced discipline of alertness and wariness of one’s surroundings. It is used for rolls to notice or pick up on sensory information, but is also important in combat, adding to the Join Battle roll that determines a character’s starting Initiative and allowing her to notice hidden enemies.'
where not exists (select 1 from dbo.Attributes where Id = 12)

INSERT dbo.Attributes select 13, 'Brawl', 2, '<b>This Ability is important in combat.</b><br/>  Brawl is used by unarmed combatants who fight based on instinct and a natural talent for violence, rather than any particular discipline or style. It’s used for punches, kicks, head-butts, shoulder thrusts, grappling, and all similar methods of using one’s own body as a weapon. Brawl also conveys an aptitude for brawling aides such as brass knuckles and improvised weaponry such as chairs and broken bottles. In addition to covering attacks, Brawl can also be used to calculate a character’s Parry rating in combat, although parrying a weapon capable of inflicting lethal damage with one’s bare hands requires a stunt.'
where not exists (select 1 from dbo.Attributes where Id = 13)

INSERT dbo.Attributes select 14, 'Bureaucracy', 2, 'Bureaucracy represents a character’s acumen in organizational, mercantile, and legal endeavors. Bureaucracy is used to assess and evaluate the resources—both wealth and manpower—available to one’s self or one’s rivals, as well as to understand the legal codes of a society or the bureaucratic structure of an organization.'
where not exists (select 1 from dbo.Attributes where Id = 14)

INSERT dbo.Attributes select 15, 'Craft', 2, '<b>This Ability is necessary to create artifacts.</b><br/>  Craft is used to create or repair objects through skilled labor, whether forging a sword, cutting the gem for a merchant prince’s brooch, or planning and overseeing the construction of a temple. The Exalted and other supernatural beings are capable of using this Ability to create artifacts, treasures of legendary quality that possess powerful magic of their own. <br/><b>Special rules:</b> When a character first buys this Ability, she must declare an area of expertise to which her crafting skill applies. Potential areas of expertise include weapon forging, armoring, architecture, tailoring, woodwork, carpentry, cooking, and anything else a player might come up with, covering similarly broad (but not all-encompassing) concepts. Additional areas of expertise must be purchased as independent Abilities—thus, a character might have Craft (Weapon Forging) 4, and Craft (Gemcutting) 2. Of note are Craft (Artifacts) and Craft (Geomancy); these two craft skills in specific are needed to craft artifacts and design and raise manses, respectively. <br/> For mundane crafts projects, Storytellers are encouraged to be generous in interpreting logical edge cases for uses of Craft. If a character needs to repair a horseshoe, but only has Craft (Armoring), it’s reasonable to declare that the character’s Craft rating encompasses basic metal fabrication and to allow her to use her Craft rating anyway, perhaps at +1 difficulty.'
where not exists (select 1 from dbo.Attributes where Id = 15)

INSERT dbo.Attributes select 16, 'Dodge', 2, '<b>This Ability is important in combat.</b><br/> Dodge is the skill of evading one’s enemies, deftly maneuvering out of the way of attacks or managing to avoid the dangers of fighting on hazardous terrain. In combat, a character’s Dodge rating contributes to her Evasion, but is also used to escape from close-quarter conflicts with enemies or to take cover from the attacks of far-off foes.'
where not exists (select 1 from dbo.Attributes where Id = 16)

INSERT dbo.Attributes select 17, 'Integrity', 2, '<b>This Ability is important in social influence.</b><br/> Integrity is the Ability to remain resolute in one’s beliefs, principles, and decisions when they are challenged, an active discipline of self-assurance and refuting opposing arguments. It contributes to a character’s Resolve, which is used to resist the persuasion of socially skilled characters.'
where not exists (select 1 from dbo.Attributes where Id = 17)

INSERT dbo.Attributes select 18, 'Investigation', 2, 'Investigation is used to uncover hidden or obscured details through close surveillance or examination, whether it is searching a magistrate’s chamber for a hidden letter, unearthing clues at the scene of a murder, or reconstructing the details of a crime from the evidence presented before a magistrate at court.'
where not exists (select 1 from dbo.Attributes where Id = 18)

INSERT dbo.Attributes select 19, 'Larceny', 2, 'Larceny covers a range of talents that fall under the general penumbra of criminal activity. Pickpocketing, lock picking, and sleight of hand are all uses of Larceny that rely on physical deftness, but it also applies to more intellectual tasks such as creating an effective disguise, hiding evidence at the scene of a crim e, or navigating a society’s criminal underworld.'
where not exists (select 1 from dbo.Attributes where Id = 19)

INSERT dbo.Attributes select 20, 'Linguistics', 2, '<b>This Ability is important in social influence.</b><br/> Linguistics is the Ability used to compose works of writing—literary epics, poetic verse, propaganda pamphlets, or even a simple conversational letter. It can be used to influence the thoughts and feelings of characters who read the work using social actions. <b>A character must have at least one dot of Linguistics to be able to read.</b>'
where not exists (select 1 from dbo.Attributes where Id = 20)

INSERT dbo.Attributes select 21, 'Lore', 2, '<b>This Ability is necessary to create artifacts.</b><br/> Lore represents a character’s understanding of the world, covering academic disciplines of history, mathematics, geography, literature, science, philosophy, and similar scholarly pursuits. It can be used both to recall useful pieces of academic knowledge, as well as to perform scholarly research in a library or archive. It is also important in the forging of artifacts and the raising of manses. Players must note the subject of their character’s education when selecting Lore, as this impacts the scope of what the Ability may cover for them (see p. 237 for more details on using Lore)— Lore 5 alone makes the character a world-class savant, but doesn’t mean she knows everything. Lore areas of expertise can be expanded with specialties and roleplaying.'
where not exists (select 1 from dbo.Attributes where Id = 21)

INSERT dbo.Attributes select 22, 'Martial Arts', 2, '<b>This Ability is important in combat.</b><br/>  Martial Arts covers formal study of martial systems, such as the styles detailed in Chapter Seven. In addition to providing mastery of unarmed techniques, Martial Arts also facilitates the use of certain exotic weapons, such as the staff, the rope dart, sais, and hook swords. Like Brawl, it can be used to calculate a character’s Parry Defense.<br/> <b>Special rules:</b> Martial Arts is a special Ability, which a character must possess the Martial Artist Merit (pgs. 163-164) to purchase. Martial Arts cannot be taken as a Caste or Favored Ability by itself. Instead, if Brawl is a Caste or Favored Ability, then so is Martial Arts. If Brawl is a Caste Ability, then Martial Arts can be taken as a character’s Supernal Ability, if desired—but if Brawl is a character’s Supernal Ability, this benefit does not extend to Martial Arts.<br/>Like Craft, when a character first buys this Ability, she must declare a martial arts style which her Martial Arts dots represent mastery of. Chapter Seven contains a number of example martial arts styles characters might choose from. Additional styles must be purchased as independent Abilities—thus, a character might have Martial Arts (Snake style) 5, and Martial Arts (Tiger style) 3.'
where not exists (select 1 from dbo.Attributes where Id = 22)

INSERT dbo.Attributes select 23, 'Medicine', 2, 'Medicine is used to diagnose and treat wounds, sickness, poisoning, and other ailments. In the Age of Sorrows, the state of Creation’s medical practice is primitive, with bone saws, sutures, and scalpels representing the most advanced medical technology a physician might have access to. In some of Creation’s cultures, methods of folk medicine such as herbal treatments, acupuncture, or therapeutic yoga take the place of traditional surgical implements, and can be just as effective, if not more so, in treating certain ailments.'
where not exists (select 1 from dbo.Attributes where Id = 23)

INSERT dbo.Attributes select 24, 'Melee', 2, '<b>This Ability is important in combat.</b><br/> Melee is the Ability of hand-to-hand weaponry, covering swords, knives, hammers, axes, lances, and any other weapon used in close quarters. It is used both to attack with these weapons and to calculate a character’s Parry rating when she blocks enemy attacks.'
where not exists (select 1 from dbo.Attributes where Id = 24)

INSERT dbo.Attributes select 25, 'Occult', 2, '<b>This Ability is necessary to create artifacts or to use Sorcery.</b><br/> Occult represents an instinctive facility for dealing with Creation’s mystical and otherworldly elements. It describes a rapport with the uncanny and things normally held beyond mortal ken. This includes understanding of the nature, powers, and ways of gods, ghosts, and demons, but also a sense of those things beyond the ken of Heaven and the gods. Occult is vital to the exorcist and the shaman, whose arts cannot be taught to those lacking proper sensitivity, and also to the sorcerer, whose senses pierce the veils of the universe.'
where not exists (select 1 from dbo.Attributes where Id = 25)

INSERT dbo.Attributes select 26, 'Performance', 2, '<b>This Ability is important in social influence.</b><br/> Performance is the Ability of influencing others through creative or artistic displays, covering both traditional forms of artistic expression such as music, dance, and poetry, as well as rhetorical speaking through prepared speeches or oratory. It can be used to influence the thoughts and feelings of other characters through social actions.'
where not exists (select 1 from dbo.Attributes where Id = 26)

INSERT dbo.Attributes select 27, 'Presence', 2, '<b>This Ability is important in social influence.</b><br/> Presence is the Ability to effectively lead, intimidate, or persuade through force of personality. It can be used to influence the thoughts and feelings of other characters through social actions. When a hot-blooded general rallies her troops with an inspiring battle cry, a witty conversationalist charms those around her over the course of a party, or a thief blurts a convincing explanation for how she came into possession of a carved jade idol, all of these characters are using Presence.'
where not exists (select 1 from dbo.Attributes where Id = 27)

INSERT dbo.Attributes select 28, 'Resistance', 2, '<b>This Ability is important in combat.</b><br/> Resistance is the learned Ability of coping with pain, disease, fatigue, and other forms of physical weakness. In combat, it is useful for fighting through the deleterious effects of poisons used by dishonorable foes, or weathering the perils of fighting over hazardous terrain.'
where not exists (select 1 from dbo.Attributes where Id = 28)

INSERT dbo.Attributes select 29, 'Ride', 2, '<b>This Ability is important in combat.</b><br/> Ride is used to ride on a horse, ox, or more exotic mount, as well as to maneuver in vehicles such as chariots or carts that are led by horses or beasts of burden. In combat, the Ride skill is used for moving across the battlefield while mounted.'
where not exists (select 1 from dbo.Attributes where Id = 29)

INSERT dbo.Attributes select 30, 'Sail', 2, 'Sail is used to captain a seafaring vessel through the great oceans and rivers that make up much of Creation. It is used for both for maneuvering a vessel and for plotting a course using sea charts and navigational instruments. While the vast majority of vehicles in the Second Age are ocean-faring ships, the Sail Ability can also be used to pilot more exotic vessels, such as the hot-air balloon skyships used by the Haslanti League or many of the ancient, wondrous vehicles lost with the First Age.'
where not exists (select 1 from dbo.Attributes where Id = 30)

INSERT dbo.Attributes select 31, 'Socialize', 2, '<b>This Ability is important in social influence.</b><br/> Socialize is a character’s understanding of the social context in which she acts, encompassing both knowledge of decorum and etiquette as well as how to use them to one’s advantage in persuasion or manipulation. In formal social situations such as an aristocratic court or a ritualized ceremony, a character can use Socialize to influence the thoughts and feelings of other characters with social actions. Socialize is also used both to read the emotional tells or body language of other characters to discern their inner thoughts, and to conceal such tells on one’s self, contributing to a character’s Guile rating.'
where not exists (select 1 from dbo.Attributes where Id = 31)

INSERT dbo.Attributes select 32, 'Stealth', 2, '<b>This Ability is important in combat.</b><br/> Stealth is used to avoid being noticed, evading the sight of one’s pursuers through physical deftness and cunning. In combat, it can be used to catch foes unawares with sneak attacks or to hide from threatening enemies. Outside of combat, it can be used for covert surveillance, silently infiltrating a guarded building, or blending into a crowd after committing a crime.'
where not exists (select 1 from dbo.Attributes where Id = 32)

INSERT dbo.Attributes select 33, 'Survival', 2, 'Survival is the Ability used to traverse and survive in wilderness environments. It covers the basic rudiments of outdoor survival, such as finding shelter, finding fresh water, and gathering food, as well as tracking, navigation, and handling animals.'
where not exists (select 1 from dbo.Attributes where Id = 33)

INSERT dbo.Attributes select 34, 'Thrown', 2, '<b>This Ability is important in combat.</b><br/> Thrown is the Ability used for weapons designed to be thrown at an enemy, rather than those which fire projectiles. Throwing knives, shuriken, javelins, chakrams, and nets are all used with this Ability.'
where not exists (select 1 from dbo.Attributes where Id = 34)

INSERT dbo.Attributes select 35, 'War', 2, '<b>This Ability is important in combat.</b><br/> War is the Ability of understanding strategy and tactics. It is used both to direct the long-term progress of a war, planning battles to gain the upper hand over enemy forces, as well as to command the soldiers or warriors that serve a character directly in battle.'
where not exists (select 1 from dbo.Attributes where Id = 35)