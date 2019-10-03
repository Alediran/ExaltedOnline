print 'Inserting Seed data for table CharmKeywords'

INSERT dbo.CharmKeywordTypes select 1, 'Aggravated', 'The Health Track damage inflicted by this Charm cannot be healed magically, nor can magic be used to speed up the natural process of healing it.'
where not exists (select 1 from dbo.CharmKeywordTypes where Id = 1)

INSERT dbo.CharmKeywordTypes select 2, 'Bridge', 'A Charm with this keyword can be purchased with alternate prerequisites from another Ability. If all the prerequisites used to buy a Bridge Charm enjoy a Caste/Favored cost discount, so does the Bridge Charm. No non-Integrity Charm can act as a prerequisite for more than one Bridge Charm, and Integrity Charms can never serve as an alternate Bridge prerequisite. If Integrity is Caste or Favored, the character may buy in via half the listed number Bridge prerequisites (round up, or round down if Supernal).'
where not exists (select 1 from dbo.CharmKeywordTypes where Id = 2)

INSERT dbo.CharmKeywordTypes select 3, 'Clash', 'Cannot be used simultaneously with or in response to a Charm with the Counterattack keyword.'
where not exists (select 1 from dbo.CharmKeywordTypes where Id = 3)

INSERT dbo.CharmKeywordTypes select 4, 'Counterattack', 'Cannot be used in reaction to a Charm with the Counterattack or Clash keyword.'
where not exists (select 1 from dbo.CharmKeywordTypes where Id = 4)

INSERT dbo.CharmKeywordTypes select 5, 'Decisive-only', 'If it’s an attack Charm, the Charm can only be used with a decisive attack. If it is a defensive Charm, it can only be used to defend against a decisive attack.'
where not exists (select 1 from dbo.CharmKeywordTypes where Id = 5)

INSERT dbo.CharmKeywordTypes select 6, 'Dual', 'This Charm has two different functions, one for withering and one for decisive.'
where not exists (select 1 from dbo.CharmKeywordTypes where Id = 6)

INSERT dbo.CharmKeywordTypes select 7, 'Mute', 'This Charm’s cost will not add to the Exalt’s anima level unless she wants it to.'
where not exists (select 1 from dbo.CharmKeywordTypes where Id = 7)

INSERT dbo.CharmKeywordTypes select 8, 'Pilot', 'The character must be the captain or the helmsman of the sailing vessel to use this Charm.'
where not exists (select 1 from dbo.CharmKeywordTypes where Id = 8)

INSERT dbo.CharmKeywordTypes select 9, 'Psyche', 'A power with this keyword is an unnatural, hypnotic, or sorcerous power that magically influences, controls, or cripples an opponent’s thoughts or feelings.'
where not exists (select 1 from dbo.CharmKeywordTypes where Id = 9)

INSERT dbo.CharmKeywordTypes select 10, 'Perilous', 'Be cautious about your reliance on this Charm! Charms with this keyword cannot be used in Initiative Crash.'
where not exists (select 1 from dbo.CharmKeywordTypes where Id = 10)

INSERT dbo.CharmKeywordTypes select 11, 'Salient', 'This keyword indicates that the Charm’s cost requires silver, gold, and white points for major, superior, and legendary craft projects, respectively.'
where not exists (select 1 from dbo.CharmKeywordTypes where Id = 11)

INSERT dbo.CharmKeywordTypes select 12, 'Stackable', 'This Charm’s effects can stack.'
where not exists (select 1 from dbo.CharmKeywordTypes where Id = 12)

INSERT dbo.CharmKeywordTypes select 13, 'Uniform', 'This Charm has the same function for both withering and decisive attacks or defenses.'
where not exists (select 1 from dbo.CharmKeywordTypes where Id = 13)

INSERT dbo.CharmKeywordTypes select 14, 'Withering-Only', 'If it’s an attack Charm, the Charm can only be used with a withering attack. If it is a defensive Charm, it can only be used to defend against a withering attack.'
where not exists (select 1 from dbo.CharmKeywordTypes where Id = 14)

INSERT dbo.CharmKeywordTypes select 15, 'Written-only', 'A Charm with this keyword can only be used to enhance, supplement, or create written social influence.'
where not exists (select 1 from dbo.CharmKeywordTypes where Id = 15)