print 'Inserting Seed data for table TreeTypes'

INSERT dbo.TreeTypes select 1, 'Solar'
where not exists (select 1 from dbo.TreeTypes where Id = 1)

INSERT dbo.TreeTypes select 2, 'Lunar'
where not exists (select 1 from dbo.TreeTypes where Id = 2)

INSERT dbo.TreeTypes select 3, 'Sidereal'
where not exists (select 1 from dbo.TreeTypes where Id = 3)

INSERT dbo.TreeTypes select 4, 'Dragon-Blooded'
where not exists (select 1 from dbo.TreeTypes where Id = 4)

INSERT dbo.TreeTypes select 5, 'Abyssal'
where not exists (select 1 from dbo.TreeTypes where Id = 5)

INSERT dbo.TreeTypes select 6, 'Infernal'
where not exists (select 1 from dbo.TreeTypes where Id = 6)

INSERT dbo.TreeTypes select 7, 'Alchemical'
where not exists (select 1 from dbo.TreeTypes where Id = 7)