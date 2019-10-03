ALTER TABLE [dbo].[CharmKeywords]
	ADD CONSTRAINT [FK_CharmKeywords_CharmKeywordTypes]
	FOREIGN KEY (KeywordId)
	REFERENCES [dbo].[CharmKeywordTypes] (Id)
