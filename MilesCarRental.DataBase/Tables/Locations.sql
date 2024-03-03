CREATE TABLE [dbo].[Locations](
	[Id] [uniqueidentifier] NOT NULL,
	[Description] [varchar](50) NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[Latitude] [decimal](10, 7) NOT NULL,
	[Longitude] [decimal](10, 7) NOT NULL,
 CONSTRAINT [PK_Locations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
