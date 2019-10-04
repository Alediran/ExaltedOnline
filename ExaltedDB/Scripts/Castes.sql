print 'Inserting Seed data for table Castes'

--Solars
INSERT dbo.Castes select 1, 1, 'Dawn', 'Warriors and Generals of the Unconquered Sun'
where not exists (select 1 from dbo.Castes where Id = 1)

INSERT dbo.Castes select 2, 1,  'Zenith', 'Priests of the Unconquered Sun'
where not exists (select 1 from dbo.Castes where Id = 2)

INSERT dbo.Castes select 3, 1,  'Twilight', 'Sorcerers, Crafters and Loremasters of the Unconquered Sun'
where not exists (select 1 from dbo.Castes where Id = 3)

INSERT dbo.Castes select 4, 1,  'Night', 'Spies and Assassins of the Unconquered Sun'
where not exists (select 1 from dbo.Castes where Id = 4)

INSERT dbo.Castes select 5, 1,  'Eclipse', 'Diplomats and Bureaucrats of the Unconquered Sun'
where not exists (select 1 from dbo.Castes where Id = 5)

--Lunars
INSERT dbo.Castes select 6, 2,  'Full Moon', 'Warriors and Berserkers of Luna'
where not exists (select 1 from dbo.Castes where Id = 6)

INSERT dbo.Castes select 7, 2,  'Changing Moon', 'Socialites of Luna'
where not exists (select 1 from dbo.Castes where Id = 7)

INSERT dbo.Castes select 8, 2,  'No Moon', 'Mystics of Luna'
where not exists (select 1 from dbo.Castes where Id = 8)

--Sidereals
INSERT dbo.Castes select 9, 3,  'Journeys', 'Chosen of Mercury'
where not exists (select 1 from dbo.Castes where Id = 9)

INSERT dbo.Castes select 10, 3,  'Serenity', 'Chosen of Venus'
where not exists (select 1 from dbo.Castes where Id = 10)

INSERT dbo.Castes select 11, 3,  'Battles', 'Chosen of Mars'
where not exists (select 1 from dbo.Castes where Id = 11)

INSERT dbo.Castes select 12, 3,  'Secrets', 'Chosen of Jupiter'
where not exists (select 1 from dbo.Castes where Id = 12)

INSERT dbo.Castes select 13, 3,  'Endings', 'Chosen of Saturn'
where not exists (select 1 from dbo.Castes where Id = 13)

--Dragon-Blooded
INSERT dbo.Castes select 14, 4,  'Air', ''
where not exists (select 1 from dbo.Castes where Id = 14)

INSERT dbo.Castes select 15, 4,  'Earth', ''
where not exists (select 1 from dbo.Castes where Id = 15)

INSERT dbo.Castes select 16, 4,  'Fire', ''
where not exists (select 1 from dbo.Castes where Id = 16)

INSERT dbo.Castes select 17, 4,  'Water', ''
where not exists (select 1 from dbo.Castes where Id = 17)

INSERT dbo.Castes select 18, 4,  'Wood', ''
where not exists (select 1 from dbo.Castes where Id = 18)

--Abyssal
INSERT dbo.Castes select 19, 5,  'Dusk', 'Warriors of the Underworld'
where not exists (select 1 from dbo.Castes where Id = 19)

INSERT dbo.Castes select 20, 5,  'Midnight', 'Priests of the Underworld'
where not exists (select 1 from dbo.Castes where Id = 20)

INSERT dbo.Castes select 21, 5,  'Daybreak', 'Necromancers of the Underworld'
where not exists (select 1 from dbo.Castes where Id = 21)

INSERT dbo.Castes select 22, 5,  'Day', 'Assassins of the Underworld'
where not exists (select 1 from dbo.Castes where Id = 22)

INSERT dbo.Castes select 23, 5,  'Moonshadow', 'Disrupters of the Underworld'
where not exists (select 1 from dbo.Castes where Id = 23)

--Infernal
INSERT dbo.Castes select 24, 6,  'Slayer', 'Champions of Malfeas'
where not exists (select 1 from dbo.Castes where Id = 24)

INSERT dbo.Castes select 25, 6,  'Malefactor', 'Champions of Cecelyne'
where not exists (select 1 from dbo.Castes where Id = 25)

INSERT dbo.Castes select 26, 6,  'Defiler', 'Champions of She Who Lives in Her Name'
where not exists (select 1 from dbo.Castes where Id = 26)

INSERT dbo.Castes select 27, 6,  'Scourge', 'Champions of Adorjan'
where not exists (select 1 from dbo.Castes where Id = 27)

INSERT dbo.Castes select 28, 6,  'Fiend', 'Champions of The Ebon Dragon'
where not exists (select 1 from dbo.Castes where Id = 28)

--Alchemical
INSERT dbo.Castes select 29, 7,  'Orichalcum', 'Flames of Authocthon'
where not exists (select 1 from dbo.Castes where Id = 29)

INSERT dbo.Castes select 30, 7,  'Moonsilver', 'Razors of Authocthon'
where not exists (select 1 from dbo.Castes where Id = 30)

INSERT dbo.Castes select 31, 7,  'Jade', 'Hammers of Authocthon'
where not exists (select 1 from dbo.Castes where Id = 31)

INSERT dbo.Castes select 32, 7,  'Starmetal', 'Daggers of Authocthon'
where not exists (select 1 from dbo.Castes where Id = 32)

INSERT dbo.Castes select 33, 7,  'Soulsteel', 'Scourges of Authocthon'
where not exists (select 1 from dbo.Castes where Id = 33)

INSERT dbo.Castes select 34, 7,  'Adamant', 'Servitors of Authocthon'
where not exists (select 1 from dbo.Castes where Id = 34)