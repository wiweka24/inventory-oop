CREATE TABLE [dbo].[SellTbl] (
    [BillID] INT          NOT NULL,
    [Name]   VARCHAR (50) NOT NULL,
    [Date]   VARCHAR (50) NOT NULL,
    [TotAmt] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([BillID] ASC)
);

