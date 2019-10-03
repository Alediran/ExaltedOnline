print 'Inserting Seed data for table CharmTypes'

INSERT dbo.CharmTypes select 1, 'Simple', 'A simple Charm counts as a combat action in and of itself, and obeys the normal timing rules of combat actions: it can only be used on the character’s turn. Simple Charms cannot be placed in a flurry, and as a result, a character can only use one simple Charm per round.'
where not exists (select 1 from dbo.CharmTypes where Id = 1)

INSERT dbo.CharmTypes select 2, 'Supplemental', 'Supplemental Charms enhance a non-magical action, such as an attack roll, crafting roll, or social influence roll. Supplemental Charms can generally only benefit rolls using the Ability they’re listed under, unless otherwise stated. A character may use as many supplemental Charms as she desires during a round, so long as she is taking valid actions for them to enhance. She cannot, however, activate the same Charm on the same action multiple times to stack its effect—a Solar could not, for example, activate Hungry Tiger Technique five times to enhance the same withering attack, multiplying its damage by five.'
where not exists (select 1 from dbo.CharmTypes where Id = 2)

INSERT dbo.CharmTypes select 3, 'Reflexive', 'A reflexive Charm creates a reflexive action or enhances a non-dice action, such as applying Defense against an attack, or holding one’s breath. In some cases, such as reflexive Charms to anticipate surprise attacks or to passively notice hidden details, the character may not even realize she is using the Charm until she already has! Characters may use any of their reflexive Charms at any time, so long as it makes sense for them to do so, but they can’t “stack” enhancing reflexive Charms in the same way they can’t stack supplemental Charms. Reflexive Charms which create attacks generally do so with the Ability they belong to, unless the governing Ability can’t normally attack or unless otherwise noted.'
where not exists (select 1 from dbo.CharmTypes where Id = 3)

INSERT dbo.CharmTypes select 4, 'Permanent', 'A permanent Charm is just that—a permanent enhancement to the character’s prowess, normally costing nothing to enjoy and providing its benefits passivelyat all times. The best example of a permanent Charm is Ox-Body Technique, which permanently grants characters additional health levels.'
where not exists (select 1 from dbo.CharmTypes where Id = 4)