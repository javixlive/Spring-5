USE [Mega_Library]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users](
	[userId] [uniqueidentifier] NOT NULL,
	[userName] [varchar](max) NOT NULL,
	[userPassword] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

-----------------------------------------------------------------------

CREATE TABLE [dbo].[Books](
	[bookId] [uniqueidentifier] NOT NULL,
	[bookTitle] [varchar](max) NOT NULL,
	[bookDescription] [varchar](max) NULL,
	[bookAuthor] [varchar](max) NULL,
	[bookGenre] [varchar](max) NULL,
	[bookEdition] [varchar](max) NULL,
	[bookImgUrl] [varchar](max) NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[bookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

-----------------------------------------------------------------------

CREATE TABLE [dbo].[History](
	[historyId] [uniqueidentifier] NOT NULL,
	[userId] [uniqueidentifier] NOT NULL,
	[bookId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_History] PRIMARY KEY CLUSTERED 
(
	[historyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[History]  WITH CHECK ADD  CONSTRAINT [FK_History_Books] FOREIGN KEY([bookId])
REFERENCES [dbo].[Books] ([bookId])
GO

ALTER TABLE [dbo].[History] CHECK CONSTRAINT [FK_History_Books]
GO

ALTER TABLE [dbo].[History]  WITH CHECK ADD  CONSTRAINT [FK_History_Users] FOREIGN KEY([userId])
REFERENCES [dbo].[Users] ([userId])
GO

ALTER TABLE [dbo].[History] CHECK CONSTRAINT [FK_History_Users]
GO

-----------------------------------------------------------------------

CREATE TABLE [dbo].[FavBooks](
	[favBooksId] [uniqueidentifier] NOT NULL,
	[userId] [uniqueidentifier] NOT NULL,
	[bookId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_FavBooks] PRIMARY KEY CLUSTERED 
(
	[favBooksId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[FavBooks]  WITH CHECK ADD  CONSTRAINT [FK_FavBooks_Books] FOREIGN KEY([bookId])
REFERENCES [dbo].[Books] ([bookId])
GO

ALTER TABLE [dbo].[FavBooks] CHECK CONSTRAINT [FK_FavBooks_Books]
GO

ALTER TABLE [dbo].[FavBooks]  WITH CHECK ADD  CONSTRAINT [FK_FavBooks_Users] FOREIGN KEY([userId])
REFERENCES [dbo].[Users] ([userId])
GO

ALTER TABLE [dbo].[FavBooks] CHECK CONSTRAINT [FK_FavBooks_Users]
GO

-----------------------------------------------------------------------
CREATE TABLE [dbo].[WishBooks](
	[wishBookId] [uniqueidentifier] NOT NULL,
	[userId] [uniqueidentifier] NOT NULL,
	[bookId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_WishBooks] PRIMARY KEY CLUSTERED 
(
	[wishBookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[WishBooks]  WITH CHECK ADD  CONSTRAINT [FK_WishBooks_Books] FOREIGN KEY([bookId])
REFERENCES [dbo].[Books] ([bookId])
GO

ALTER TABLE [dbo].[WishBooks] CHECK CONSTRAINT [FK_WishBooks_Books]
GO

ALTER TABLE [dbo].[WishBooks]  WITH CHECK ADD  CONSTRAINT [FK_WishBooks_Users] FOREIGN KEY([userId])
REFERENCES [dbo].[Users] ([userId])
GO

ALTER TABLE [dbo].[WishBooks] CHECK CONSTRAINT [FK_WishBooks_Users]
GO

-----------------------------------------------------------------------

Create Procedure [dbo].[sp_add_books]
	@bookId uniqueidentifier,
	@bookTitle varchar(MAX),
	@bookDescription varchar(MAX),
	@bookAuthor varchar(MAX),
	@bookEdition varchar(MAX),
	@bookImgUrl varchar(MAX)
	AS
	BEGIN
		INSERT INTO dbo.Books(bookId, bookTitle, bookDescription, bookAuthor, bookEdition, bookImgUrl)
		VALUES(@bookId, @bookTitle, @bookDescription, @bookAuthor, @bookEdition, @bookImgUrl)
	END
GO


-----------------------------------------------------------------------

Create procedure [dbo].[sp_get_FavBooks]
	@userId uniqueidentifier
AS
BEGIN
	Select * from FavBooks Where
	userId=@userId
END
GO

-----------------------------------------------------------------------

Create procedure [dbo].[sp_get_History]
	@userId uniqueidentifier
AS
BEGIN
	Select * from History Where
	userId=@userId
END
GO

-----------------------------------------------------------------------

Create procedure [dbo].[sp_get_wishlist]
	@userId uniqueidentifier
AS
BEGIN
	Select * from WishBooks Where
	userId=@userId
END
GO

-----------------------------------------------------------------------

Create procedure [dbo].[sp_users]
@userName varchar(MAX),
@userPassword varchar(MAX)
AS
BEGIN	
	Select * from Users where userName=@userName
	and userPassword = @userPassword
END
GO

-----------------------------------------------------------------------

Create Procedure [dbo].[sp_viewBooks]
@bookTitle Nvarchar(MAX)
AS
BEGIN
	IF (@bookTitle = '')
	BEGIN
		Select * from dbo.Books
	END
	ELSE
	BEGIN
		Select * from dbo.Books Where bookTitle=@BookTitle
	END
END

-----------------------------------------------------------------------