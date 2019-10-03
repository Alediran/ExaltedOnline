print 'Inserting Seed data for table CharmDurationTypes'

INSERT dbo.CharmDurationTypes select 1, 'Instant', ''
where not exists (select 1 from dbo.CharmDurationTypes where Id = 1)

INSERT dbo.CharmDurationTypes select 2, 'Scene', ''
where not exists (select 1 from dbo.CharmDurationTypes where Id = 2)

INSERT dbo.CharmDurationTypes select 3, 'One Tick', ''
where not exists (select 1 from dbo.CharmDurationTypes where Id = 3)

INSERT dbo.CharmDurationTypes select 4, 'One Turn', ''
where not exists (select 1 from dbo.CharmDurationTypes where Id = 4)

INSERT dbo.CharmDurationTypes select 5, 'Indefinite', ''
where not exists (select 1 from dbo.CharmDurationTypes where Id = 5)

INSERT dbo.CharmDurationTypes select 6, 'Permanent', ''
where not exists (select 1 from dbo.CharmDurationTypes where Id = 6)