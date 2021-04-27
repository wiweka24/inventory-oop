CREATE TABLE [dbo].[ProductTbl] (
    [ProdId]    INT          NOT NULL,
    [ProdName]  VARCHAR (50) NOT NULL,
    [ProdQty]   INT          NOT NULL,
    [ProdCat]   VARCHAR (50) NOT NULL,
    [ProdPrice] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([ProdId] ASC)
);

