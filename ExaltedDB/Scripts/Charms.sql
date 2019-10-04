print 'Inserting Seed data for table Charms'

--Charm Begins--
INSERT dbo.Charms select 1, 'Wise Arrow', 1, 1, 2, 1, 'With skill and effort, the Exalt guides her arrow to its mark. The Exalt may use this Charm to supplement a <b>withering</b> or <b>decisive</b> attack, reducing the benefits of cover. The defense bonus of heavy and light cover is reduced by one, while characters under no cover suffer a -1 penalty to their normal Defense.<br/> In addition, after taking an aim action, the Solar may activate this Charm to strike an opponent in full cover. The Exalt shoots along an arc or angle that perfectly matches her opponent’s position. So long as there is some opening where an arrow can get through, Wise Arrow treats a character in full cover as if he merely has +3 Defense.',0, NULL
where not exists (select 1 from dbo.Charms where Id = 1)

INSERT dbo.CharmCosts select 1, 1, 1, 1
where not exists (select 1 from dbo.CharmCosts where CharmId = 1 and CostTypeId = 1)

INSERT dbo.CharmAttributes select 1, 10, 1, 2
where not exists (select 1 from dbo.CharmAttributes where CharmId = 1 and AttributeId = 10)

INSERT dbo.CharmKeywords select 1, 13, 1
where not exists (select 1 from dbo.CharmKeywords where CharmId = 1 and KeywordId = 13)
--Charm Ends--

--Charm Begins--
--ID, Name, Essence Minimum, TreeTypeID, TypeID, DurationId, Description, IsCustomCharm, GameId
INSERT dbo.Charms select 16, 'Revolving Bow Discipline', 1, 3, 1, 1, 'Holding arrows between each finger, the Solar draws down on her target, firing with profound speed and focus. The Solar may draw and attack a single target repeatedly, launching multiple withering attacks until she either misses or crashes her opponent. Revolving Bow Discipline can only be used within short or close range, and can’t be used on targets already in crash. <br/> At Essence 4+, the Solar gains one point of temporary Willpower when she crashes a foe with this attack.',0, NULL
where not exists (select 1 from dbo.Charms where Id = 16)

--CharmId, CostTypeId, DisplayOrder, Quantity
INSERT dbo.CharmCosts select 16, 1, 1, 6
where not exists (select 1 from dbo.CharmCosts where CharmId = 16 and CostTypeId = 1)

INSERT dbo.CharmCosts select 16, 2, 2, 1
where not exists (select 1 from dbo.CharmCosts where CharmId = 16 and CostTypeId = 2)

--CharmId, AttributeId, DisplayOrder, AttributeLevel
INSERT dbo.CharmAttributes select 16, 10, 1, 5
where not exists (select 1 from dbo.CharmAttributes where CharmId = 16 and AttributeId = 10)

--CharmId, KeywordId, DisplayOrder
INSERT dbo.CharmKeywords select 16, 10, 1
where not exists (select 1 from dbo.CharmKeywords where CharmId = 16 and KeywordId = 10)

INSERT dbo.CharmKeywords select 16, 14, 1
where not exists (select 1 from dbo.CharmKeywords where CharmId = 16 and KeywordId = 14)
--Charm Ends--