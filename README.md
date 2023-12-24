# AirlineTicktingApplication


1.BookedTicket-----------------------------------------------------------------

CREATE TABLE [dbo].[BookedTicket] (
    [Flight]       VARCHAR (20) NOT NULL,
    [From]         VARCHAR (20) NOT NULL,
    [To]           VARCHAR (20) NOT NULL,
    [Date]         VARCHAR (50) NOT NULL,
    [Seat]         INT          NOT NULL,
    [Customer]     VARCHAR (20) NOT NULL,
    [Booking_Date] VARCHAR (20) NOT NULL
);

2.CanceledFlight-----------------------------------------------------------------

CREATE TABLE [dbo].[CanceledFlight] (
    [Flight]      VARCHAR (20) NOT NULL,
    [From]        VARCHAR (20) NOT NULL,
    [To]          VARCHAR (20) NOT NULL,
    [Date]        VARCHAR (50) NOT NULL,
    [Seat]        INT          NOT NULL,
    [Canceled_By] VARCHAR (20) NOT NULL
);


3.FlightTbl-----------------------------------------------------------------

CREATE TABLE [dbo].[FlightTbl] (
    [Flight] VARCHAR (20) NOT NULL,
    [From]   VARCHAR (20) NOT NULL,
    [To]     VARCHAR (20) NOT NULL,
    [Date]   VARCHAR (50) NOT NULL,
    [Seat]   INT          NOT NULL
);

4.PassengerTbl-----------------------------------------------------------------

CREATE TABLE [dbo].[PassengerTbl] (
    [PassName]  VARCHAR (20) NOT NULL,
    [Password]  VARCHAR (20) NOT NULL,
    [Passport]  VARCHAR (20) NOT NULL,
    [PassAd]    VARCHAR (50) NOT NULL,
    [PassNat]   VARCHAR (50) NOT NULL,
    [PassGend]  VARCHAR (10) NOT NULL,
    [PassPhone] VARCHAR (20) NOT NULL
);


