/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/


:r .\CharmTypes.sql --Inserts the Charm Types data
:r .\CharmKeywordTypes.sql --Inserts the Charm Keywords data
:r .\CharmDurationTypes.sql --Inserts the Charm Duration data
:r .\CharmCostTypes.sql --Inserts the Charm Cost Types data
:r .\Traits.sql --Inserts the Attributes data
:r .\Charms.sql --Inserts the Charm data
:r .\IntimaciesIntensity.sql --Inserts the Intimacies Intensity data