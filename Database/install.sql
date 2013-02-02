CREATE TABLE Game(
  Id     INTEGER PRIMARY KEY AUTOINCREMENT,
  [Date]   Date NOT NULL,
  WinnerHand NVARCHAR(20) NOT NULL,
  BuyInValue INTEGER NOT NULL
);

CREATE TABLE Player(
  Id     INTEGER PRIMARY KEY AUTOINCREMENT,
  Name   NVARCHAR(128) NOT NULL,
  WindowsLogin NVARCHAR(128) NOT NULL
);

CREATE TABLE GamePlayer(
  GameId     INTEGER NOT NULL,
  PlayerId   INTEGER NOT NULL,
  Rank INTEGER,
  PRIMARY KEY (GameId, PlayerId),
  FOREIGN KEY(GameId) REFERENCES Game(Id),
  FOREIGN KEY(PlayerId) REFERENCES Player(Id)
);