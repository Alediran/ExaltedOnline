print 'Inserting Seed data for table CharmCostTypes'

INSERT dbo.CharmCostTypes select 1, 'Mote', '', 'Xm'
where not exists (select 1 from dbo.CharmCostTypes where Id = 1)

INSERT dbo.CharmCostTypes select 2, 'Willpower', '', 'Xwp'
where not exists (select 1 from dbo.CharmCostTypes where Id = 2)

INSERT dbo.CharmCostTypes select 3, 'Initiative', '', 'Xi'
where not exists (select 1 from dbo.CharmCostTypes where Id = 3)

INSERT dbo.CharmCostTypes select 4, 'Bashing Health Level', '', 'Xhl'
where not exists (select 1 from dbo.CharmCostTypes where Id = 4)

INSERT dbo.CharmCostTypes select 5, 'Lethal Health Level', '', 'Xlhl'
where not exists (select 1 from dbo.CharmCostTypes where Id = 5)

INSERT dbo.CharmCostTypes select 6, 'Aggravated Health Level', '', 'Xahl'
where not exists (select 1 from dbo.CharmCostTypes where Id = 6)

INSERT dbo.CharmCostTypes select 7, 'Anima Level', '', 'Xa'
where not exists (select 1 from dbo.CharmCostTypes where Id = 7)

INSERT dbo.CharmCostTypes select 8, 'Experience Points', '', 'Xxp'
where not exists (select 1 from dbo.CharmCostTypes where Id = 8)

INSERT dbo.CharmCostTypes select 9, 'Silver Crafting Experience Points', '', 'Xsxp'
where not exists (select 1 from dbo.CharmCostTypes where Id = 9)

INSERT dbo.CharmCostTypes select 10, 'Gold Crafting Experience Points', '', 'Xgxp'
where not exists (select 1 from dbo.CharmCostTypes where Id = 10)

INSERT dbo.CharmCostTypes select 11, 'White Crafting Experience Points', '', 'Xwxp'
where not exists (select 1 from dbo.CharmCostTypes where Id = 11)