print 'Inserting Seed data for table IntimaciesIntensity'

INSERT dbo.IntimaciesIntensity select 1, 'Minor', 'Minor Intimacies are notable parts of your character’s worldview, but only come into play when the subject of the Intimacy is directly relevant to her current situation.'
where not exists (select 1 from dbo.IntimaciesIntensity where Id = 1)

INSERT dbo.IntimaciesIntensity select 2, 'Major', 'Major Intimacies hold more influence over your character, coming into play even if the subject is only indirectly or tangentially related to the situation at hand.'
where not exists (select 1 from dbo.IntimaciesIntensity where Id = 2)

INSERT dbo.IntimaciesIntensity select 3, 'Defining', 'Defining Intimacies hold sway over every aspect of your character’s life—they’re the pillars of her worldview, and often things she would lay down her life to protect.'
where not exists (select 1 from dbo.IntimaciesIntensity where Id = 3)