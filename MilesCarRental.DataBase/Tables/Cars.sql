CREATE TABLE [dbo].[Cars](
	[Id] [uniqueidentifier] NOT NULL,
	[Brand] [varchar](50) NOT NULL,
	[Line] [varchar](50) NOT NULL,
	[Model] [smallint] NOT NULL,
	[Color] [varchar](50) NOT NULL,
	[Plate] [varchar](50) NOT NULL,
	[PickUpLocation] [uniqueidentifier] NOT NULL,
	[ReturnLocationId] [uniqueidentifier] NOT NULL,
	[Available] [bit] NOT NULL,
 CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Cars] ADD  DEFAULT ((0)) FOR [Available]
GO

ALTER TABLE [dbo].[Cars]  WITH CHECK ADD  CONSTRAINT [FK_Cars_PickUpLocations] FOREIGN KEY([PickUpLocation])
REFERENCES [dbo].[Locations] ([Id])
GO

ALTER TABLE [dbo].[Cars] CHECK CONSTRAINT [FK_Cars_PickUpLocations]
GO

ALTER TABLE [dbo].[Cars]  WITH CHECK ADD  CONSTRAINT [FK_Cars_ReturnLocations] FOREIGN KEY([ReturnLocationId])
REFERENCES [dbo].[Locations] ([Id])
GO

ALTER TABLE [dbo].[Cars] CHECK CONSTRAINT [FK_Cars_ReturnLocations]
GO
