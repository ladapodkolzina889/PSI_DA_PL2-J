
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/27/2022 13:46:59
-- Generated from EDMX file: C:\Users\2213180\source\repos\Projeto_DA\Projeto_DA\RestGest.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ResGest];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'PessoaSet'
CREATE TABLE [dbo].[PessoaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [IdMorada] nvarchar(max)  NOT NULL,
    [Telemovel] nvarchar(max)  NOT NULL,
    [Morada_Rua] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MoradaSet'
CREATE TABLE [dbo].[MoradaSet] (
    [Rua] nvarchar(max)  NOT NULL,
    [Cidade] nvarchar(max)  NOT NULL,
    [CodPostal] nvarchar(max)  NOT NULL,
    [Pais] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'RestauranteSet'
CREATE TABLE [dbo].[RestauranteSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Morada1_Rua] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PagamentoSet'
CREATE TABLE [dbo].[PagamentoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdPedido] nvarchar(max)  NOT NULL,
    [IdMetodoPagamento] nvarchar(max)  NOT NULL,
    [Valor] decimal(18,0)  NOT NULL,
    [PedidoId] int  NOT NULL,
    [metodoPagamento_Id] int  NOT NULL
);
GO

-- Creating table 'PedidoSet'
CREATE TABLE [dbo].[PedidoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdTrabalhador] nvarchar(max)  NOT NULL,
    [IdCliente] nvarchar(max)  NOT NULL,
    [IdRestaurante] nvarchar(max)  NOT NULL,
    [IdEstado] nvarchar(max)  NOT NULL,
    [ValorTotal] decimal(18,0)  NOT NULL,
    [RestauranteId] int  NOT NULL,
    [ClienteId] int  NOT NULL,
    [Estado_Id] int  NOT NULL
);
GO

-- Creating table 'EstadoSet'
CREATE TABLE [dbo].[EstadoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Status] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CategoriaSet'
CREATE TABLE [dbo].[CategoriaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Ativo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ItemMenuSet'
CREATE TABLE [dbo].[ItemMenuSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdCategoria] nvarchar(max)  NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Fotografia] nvarchar(max)  NOT NULL,
    [Ingredientes] nvarchar(max)  NOT NULL,
    [Preco] decimal(18,0)  NOT NULL,
    [Ativo] nvarchar(max)  NOT NULL,
    [Categoria_Id] int  NOT NULL
);
GO

-- Creating table 'metodoPagamentoSet'
CREATE TABLE [dbo].[metodoPagamentoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [MetodoDePagamento] nvarchar(max)  NOT NULL,
    [Ativo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PessoaSet_Trabalhador'
CREATE TABLE [dbo].[PessoaSet_Trabalhador] (
    [RestauranteId] int  NOT NULL,
    [Salario] decimal(18,0)  NOT NULL,
    [Posicao] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'PessoaSet_Cliente'
CREATE TABLE [dbo].[PessoaSet_Cliente] (
    [TotalGasto] decimal(18,0)  NOT NULL,
    [NumContribuinte] int  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'RestauranteItemMenu'
CREATE TABLE [dbo].[RestauranteItemMenu] (
    [Restaurante_Id] int  NOT NULL,
    [ItemMenu_Id] int  NOT NULL
);
GO

-- Creating table 'ItemMenuPedido'
CREATE TABLE [dbo].[ItemMenuPedido] (
    [ItemMenu_Id] int  NOT NULL,
    [Pedido_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'PessoaSet'
ALTER TABLE [dbo].[PessoaSet]
ADD CONSTRAINT [PK_PessoaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Rua] in table 'MoradaSet'
ALTER TABLE [dbo].[MoradaSet]
ADD CONSTRAINT [PK_MoradaSet]
    PRIMARY KEY CLUSTERED ([Rua] ASC);
GO

-- Creating primary key on [Id] in table 'RestauranteSet'
ALTER TABLE [dbo].[RestauranteSet]
ADD CONSTRAINT [PK_RestauranteSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PagamentoSet'
ALTER TABLE [dbo].[PagamentoSet]
ADD CONSTRAINT [PK_PagamentoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PedidoSet'
ALTER TABLE [dbo].[PedidoSet]
ADD CONSTRAINT [PK_PedidoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EstadoSet'
ALTER TABLE [dbo].[EstadoSet]
ADD CONSTRAINT [PK_EstadoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CategoriaSet'
ALTER TABLE [dbo].[CategoriaSet]
ADD CONSTRAINT [PK_CategoriaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ItemMenuSet'
ALTER TABLE [dbo].[ItemMenuSet]
ADD CONSTRAINT [PK_ItemMenuSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'metodoPagamentoSet'
ALTER TABLE [dbo].[metodoPagamentoSet]
ADD CONSTRAINT [PK_metodoPagamentoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PessoaSet_Trabalhador'
ALTER TABLE [dbo].[PessoaSet_Trabalhador]
ADD CONSTRAINT [PK_PessoaSet_Trabalhador]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PessoaSet_Cliente'
ALTER TABLE [dbo].[PessoaSet_Cliente]
ADD CONSTRAINT [PK_PessoaSet_Cliente]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Restaurante_Id], [ItemMenu_Id] in table 'RestauranteItemMenu'
ALTER TABLE [dbo].[RestauranteItemMenu]
ADD CONSTRAINT [PK_RestauranteItemMenu]
    PRIMARY KEY CLUSTERED ([Restaurante_Id], [ItemMenu_Id] ASC);
GO

-- Creating primary key on [ItemMenu_Id], [Pedido_Id] in table 'ItemMenuPedido'
ALTER TABLE [dbo].[ItemMenuPedido]
ADD CONSTRAINT [PK_ItemMenuPedido]
    PRIMARY KEY CLUSTERED ([ItemMenu_Id], [Pedido_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Morada_Rua] in table 'PessoaSet'
ALTER TABLE [dbo].[PessoaSet]
ADD CONSTRAINT [FK_PessoaMorada]
    FOREIGN KEY ([Morada_Rua])
    REFERENCES [dbo].[MoradaSet]
        ([Rua])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PessoaMorada'
CREATE INDEX [IX_FK_PessoaMorada]
ON [dbo].[PessoaSet]
    ([Morada_Rua]);
GO

-- Creating foreign key on [Morada1_Rua] in table 'RestauranteSet'
ALTER TABLE [dbo].[RestauranteSet]
ADD CONSTRAINT [FK_MoradaRestaurante]
    FOREIGN KEY ([Morada1_Rua])
    REFERENCES [dbo].[MoradaSet]
        ([Rua])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MoradaRestaurante'
CREATE INDEX [IX_FK_MoradaRestaurante]
ON [dbo].[RestauranteSet]
    ([Morada1_Rua]);
GO

-- Creating foreign key on [RestauranteId] in table 'PessoaSet_Trabalhador'
ALTER TABLE [dbo].[PessoaSet_Trabalhador]
ADD CONSTRAINT [FK_RestauranteTrabalhador]
    FOREIGN KEY ([RestauranteId])
    REFERENCES [dbo].[RestauranteSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RestauranteTrabalhador'
CREATE INDEX [IX_FK_RestauranteTrabalhador]
ON [dbo].[PessoaSet_Trabalhador]
    ([RestauranteId]);
GO

-- Creating foreign key on [RestauranteId] in table 'PedidoSet'
ALTER TABLE [dbo].[PedidoSet]
ADD CONSTRAINT [FK_RestaurantePedido]
    FOREIGN KEY ([RestauranteId])
    REFERENCES [dbo].[RestauranteSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RestaurantePedido'
CREATE INDEX [IX_FK_RestaurantePedido]
ON [dbo].[PedidoSet]
    ([RestauranteId]);
GO

-- Creating foreign key on [Restaurante_Id] in table 'RestauranteItemMenu'
ALTER TABLE [dbo].[RestauranteItemMenu]
ADD CONSTRAINT [FK_RestauranteItemMenu_Restaurante]
    FOREIGN KEY ([Restaurante_Id])
    REFERENCES [dbo].[RestauranteSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ItemMenu_Id] in table 'RestauranteItemMenu'
ALTER TABLE [dbo].[RestauranteItemMenu]
ADD CONSTRAINT [FK_RestauranteItemMenu_ItemMenu]
    FOREIGN KEY ([ItemMenu_Id])
    REFERENCES [dbo].[ItemMenuSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RestauranteItemMenu_ItemMenu'
CREATE INDEX [IX_FK_RestauranteItemMenu_ItemMenu]
ON [dbo].[RestauranteItemMenu]
    ([ItemMenu_Id]);
GO

-- Creating foreign key on [Categoria_Id] in table 'ItemMenuSet'
ALTER TABLE [dbo].[ItemMenuSet]
ADD CONSTRAINT [FK_ItemMenuCategoria]
    FOREIGN KEY ([Categoria_Id])
    REFERENCES [dbo].[CategoriaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemMenuCategoria'
CREATE INDEX [IX_FK_ItemMenuCategoria]
ON [dbo].[ItemMenuSet]
    ([Categoria_Id]);
GO

-- Creating foreign key on [ItemMenu_Id] in table 'ItemMenuPedido'
ALTER TABLE [dbo].[ItemMenuPedido]
ADD CONSTRAINT [FK_ItemMenuPedido_ItemMenu]
    FOREIGN KEY ([ItemMenu_Id])
    REFERENCES [dbo].[ItemMenuSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Pedido_Id] in table 'ItemMenuPedido'
ALTER TABLE [dbo].[ItemMenuPedido]
ADD CONSTRAINT [FK_ItemMenuPedido_Pedido]
    FOREIGN KEY ([Pedido_Id])
    REFERENCES [dbo].[PedidoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemMenuPedido_Pedido'
CREATE INDEX [IX_FK_ItemMenuPedido_Pedido]
ON [dbo].[ItemMenuPedido]
    ([Pedido_Id]);
GO

-- Creating foreign key on [ClienteId] in table 'PedidoSet'
ALTER TABLE [dbo].[PedidoSet]
ADD CONSTRAINT [FK_ClientePedido]
    FOREIGN KEY ([ClienteId])
    REFERENCES [dbo].[PessoaSet_Cliente]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientePedido'
CREATE INDEX [IX_FK_ClientePedido]
ON [dbo].[PedidoSet]
    ([ClienteId]);
GO

-- Creating foreign key on [PedidoId] in table 'PagamentoSet'
ALTER TABLE [dbo].[PagamentoSet]
ADD CONSTRAINT [FK_PedidoPagamento]
    FOREIGN KEY ([PedidoId])
    REFERENCES [dbo].[PedidoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PedidoPagamento'
CREATE INDEX [IX_FK_PedidoPagamento]
ON [dbo].[PagamentoSet]
    ([PedidoId]);
GO

-- Creating foreign key on [metodoPagamento_Id] in table 'PagamentoSet'
ALTER TABLE [dbo].[PagamentoSet]
ADD CONSTRAINT [FK_PagamentometodoPagamento]
    FOREIGN KEY ([metodoPagamento_Id])
    REFERENCES [dbo].[metodoPagamentoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PagamentometodoPagamento'
CREATE INDEX [IX_FK_PagamentometodoPagamento]
ON [dbo].[PagamentoSet]
    ([metodoPagamento_Id]);
GO

-- Creating foreign key on [Estado_Id] in table 'PedidoSet'
ALTER TABLE [dbo].[PedidoSet]
ADD CONSTRAINT [FK_PedidoEstado]
    FOREIGN KEY ([Estado_Id])
    REFERENCES [dbo].[EstadoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PedidoEstado'
CREATE INDEX [IX_FK_PedidoEstado]
ON [dbo].[PedidoSet]
    ([Estado_Id]);
GO

-- Creating foreign key on [Id] in table 'PessoaSet_Trabalhador'
ALTER TABLE [dbo].[PessoaSet_Trabalhador]
ADD CONSTRAINT [FK_Trabalhador_inherits_Pessoa]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[PessoaSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'PessoaSet_Cliente'
ALTER TABLE [dbo].[PessoaSet_Cliente]
ADD CONSTRAINT [FK_Cliente_inherits_Pessoa]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[PessoaSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------