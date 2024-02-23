-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 23. Feb 2024 um 16:03
-- Server-Version: 10.4.28-MariaDB
-- PHP-Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `financeapp`
--
CREATE DATABASE IF NOT EXISTS `financeapp` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `financeapp`;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `account`
--

CREATE TABLE `account` (
  `ID` int(11) NOT NULL,
  `Credit` int(11) NOT NULL,
  `UserID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `account`
--

INSERT INTO `account` (`ID`, `Credit`, `UserID`) VALUES
(2, 530160, 14),
(3, 10000, 22);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `apidetails`
--

CREATE TABLE `apidetails` (
  `ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `financetransaction`
--

CREATE TABLE `financetransaction` (
  `ID` int(11) NOT NULL,
  `TransactionType` enum('Buy','Sell') NOT NULL,
  `Ammount` int(11) NOT NULL,
  `Date` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `ShareValueId` int(11) NOT NULL,
  `UserID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `financetransaction`
--

INSERT INTO `financetransaction` (`ID`, `TransactionType`, `Ammount`, `Date`, `ShareValueId`, `UserID`) VALUES
(3, 'Buy', 1, '2024-02-09 14:51:34', 3, 14),
(4, 'Buy', 1, '2024-02-09 14:52:28', 3, 14),
(5, 'Buy', 1, '2024-02-09 16:01:50', 3, 14),
(6, 'Sell', 1, '2024-02-09 14:53:36', 3, 14),
(7, 'Buy', 1, '2024-02-09 14:53:41', 3, 14),
(8, 'Sell', 1, '2024-02-22 09:10:53', 3, 14),
(9, 'Buy', 1, '2024-02-22 09:11:06', 3, 14),
(10, 'Buy', 1, '2024-02-22 09:11:10', 3, 14),
(11, 'Buy', 1, '2024-02-22 09:41:12', 3, 14),
(12, 'Sell', 1, '2024-02-22 09:45:13', 6, 14),
(13, 'Buy', 1, '2024-02-22 09:45:47', 6, 14),
(14, 'Buy', 1, '2024-02-22 09:46:27', 6, 14),
(15, 'Buy', 1, '2024-02-22 09:46:32', 9, 14),
(16, 'Sell', 1, '2024-02-22 09:47:11', 9, 14),
(17, 'Sell', 1, '2024-02-22 09:47:13', 6, 14),
(18, 'Sell', 1, '2024-02-22 09:47:14', 6, 14),
(19, 'Buy', 1, '2024-02-22 09:47:39', 6, 14),
(20, 'Buy', 1, '2024-02-22 09:50:12', 9, 14),
(21, 'Sell', 1, '2024-02-22 09:50:18', 9, 14),
(22, 'Sell', 1, '2024-02-22 09:50:19', 6, 14),
(23, 'Sell', 1, '2024-02-22 10:14:19', 3, 14),
(24, 'Buy', 1, '2024-02-22 10:15:11', 3, 14),
(25, 'Buy', 1, '2024-02-22 10:15:12', 3, 14),
(26, 'Buy', 1, '2024-02-22 10:15:13', 3, 14),
(27, 'Buy', 1, '2024-02-22 10:15:14', 3, 14),
(28, 'Buy', 1, '2024-02-22 10:15:15', 3, 14),
(29, 'Buy', 1, '2024-02-22 10:15:16', 3, 14),
(30, 'Buy', 1, '2024-02-22 10:15:17', 3, 14),
(31, 'Buy', 1, '2024-02-22 10:15:17', 3, 14),
(32, 'Buy', 1, '2024-02-22 10:15:17', 3, 14),
(33, 'Buy', 1, '2024-02-22 10:15:18', 3, 14),
(34, 'Buy', 1, '2024-02-22 10:15:18', 3, 14),
(35, 'Buy', 1, '2024-02-22 10:15:26', 3, 14),
(36, 'Buy', 1, '2024-02-22 10:15:26', 3, 14),
(37, 'Buy', 1, '2024-02-22 10:15:27', 3, 14),
(38, 'Sell', 1, '2024-02-22 10:15:32', 3, 14),
(39, 'Sell', 1, '2024-02-22 10:15:33', 3, 14),
(40, 'Sell', 1, '2024-02-22 10:15:34', 3, 14),
(41, 'Sell', 1, '2024-02-22 10:15:34', 3, 14),
(42, 'Sell', 1, '2024-02-22 10:15:35', 3, 14),
(43, 'Sell', 1, '2024-02-22 10:15:36', 3, 14),
(44, 'Sell', 1, '2024-02-22 10:15:36', 3, 14),
(45, 'Sell', 1, '2024-02-22 10:15:37', 3, 14),
(46, 'Sell', 1, '2024-02-22 10:15:38', 3, 14),
(47, 'Sell', 1, '2024-02-22 10:15:38', 3, 14),
(48, 'Buy', 1, '2024-02-23 14:42:12', 21, 14),
(49, 'Sell', 1, '2024-02-23 14:42:21', 21, 14);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `possession`
--

CREATE TABLE `possession` (
  `ID` int(11) NOT NULL,
  `Number` int(11) NOT NULL,
  `AccountID` int(11) NOT NULL,
  `SharesID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `possession`
--

INSERT INTO `possession` (`ID`, `Number`, `AccountID`, `SharesID`) VALUES
(3, 6, 2, 1);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `shares`
--

CREATE TABLE `shares` (
  `ID` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `shares`
--

INSERT INTO `shares` (`ID`, `Name`) VALUES
(1, 'Bitcoin'),
(2, 'Apple'),
(3, 'Microsoft'),
(4, 'Amazon'),
(5, 'Google'),
(6, 'Facebook'),
(12, 'ETH-CAD');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `sharevalue`
--

CREATE TABLE `sharevalue` (
  `ID` int(11) NOT NULL,
  `Value` int(11) NOT NULL,
  `TimeStamp` datetime NOT NULL,
  `SharesID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `sharevalue`
--

INSERT INTO `sharevalue` (`ID`, `Value`, `TimeStamp`, `SharesID`) VALUES
(2, 44000, '2024-02-07 10:02:05', 1),
(3, 50000, '2024-02-09 10:02:05', 1),
(4, 150, '2024-01-01 09:00:00', 2),
(5, 155, '2024-01-02 09:00:00', 2),
(6, 160, '2024-01-03 09:00:00', 2),
(7, 200, '2024-01-01 09:00:00', 3),
(8, 205, '2024-01-02 09:00:00', 3),
(9, 210, '2024-01-03 09:00:00', 3),
(10, 1800, '2024-01-01 09:00:00', 4),
(11, 1825, '2024-01-02 09:00:00', 4),
(12, 1850, '2024-01-03 09:00:00', 4),
(13, 2500, '2024-01-01 09:00:00', 5),
(14, 2550, '2024-01-02 09:00:00', 5),
(15, 300, '2024-01-01 09:00:00', 6),
(16, 305, '2024-01-02 09:00:00', 6),
(17, 310, '2024-01-03 09:00:00', 6),
(18, 2600, '2024-01-03 09:00:00', 5),
(21, 3965, '2024-02-23 14:39:05', 12);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `user`
--

CREATE TABLE `user` (
  `ID` int(11) NOT NULL,
  `FirstName` varchar(255) NOT NULL,
  `LastName` varchar(255) DEFAULT NULL,
  `UserName` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `user`
--

INSERT INTO `user` (`ID`, `FirstName`, `LastName`, `UserName`) VALUES
(1, 'max', 'musternmann', 'max1'),
(2, 'max', NULL, 'max2'),
(7, 'Peter', 'Lustig', 'Peter'),
(9, 'Peter', 'Lustig', 'Peter1'),
(11, 'Peter', 'Lustig', 'Peter2'),
(12, 'Peter', 'Lustig', 'Peter3'),
(14, 'Peter', 'Lustig', 'Peter4'),
(15, 'Karl', 'das Lama', 'KarlDasLama'),
(18, 'Karl', 'das Lama', 'KarlDasLama1'),
(19, 'Thomas', NULL, 'TheThomas'),
(21, 'Thomas', NULL, 'TheThomas2'),
(22, 'Frank', NULL, 'Franky'),
(23, 'wadsa', 'wadas', 'wadsa'),
(24, 'MrG', 'derWeiße', 'MrGderWeiße'),
(25, 'neuer', 'Maunuel', 'manuelNeuer'),
(26, 'herrmann', 'frau', 'frauherrmann');

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `account`
--
ALTER TABLE `account`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `account_FK` (`UserID`);

--
-- Indizes für die Tabelle `apidetails`
--
ALTER TABLE `apidetails`
  ADD PRIMARY KEY (`ID`);

--
-- Indizes für die Tabelle `financetransaction`
--
ALTER TABLE `financetransaction`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `FK_FinanceTransaction_ShareValueId` (`ShareValueId`),
  ADD KEY `FK_FinanceTransaction_UserId` (`UserID`);

--
-- Indizes für die Tabelle `possession`
--
ALTER TABLE `possession`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `unique_AccountFK_SharesFK` (`AccountID`,`SharesID`),
  ADD KEY `SharesFK` (`SharesID`);

--
-- Indizes für die Tabelle `shares`
--
ALTER TABLE `shares`
  ADD PRIMARY KEY (`ID`);

--
-- Indizes für die Tabelle `sharevalue`
--
ALTER TABLE `sharevalue`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `SharesFK` (`SharesID`);

--
-- Indizes für die Tabelle `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `unique_username` (`UserName`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `account`
--
ALTER TABLE `account`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT für Tabelle `apidetails`
--
ALTER TABLE `apidetails`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT für Tabelle `financetransaction`
--
ALTER TABLE `financetransaction`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=50;

--
-- AUTO_INCREMENT für Tabelle `possession`
--
ALTER TABLE `possession`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT für Tabelle `shares`
--
ALTER TABLE `shares`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT für Tabelle `sharevalue`
--
ALTER TABLE `sharevalue`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT für Tabelle `user`
--
ALTER TABLE `user`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `account`
--
ALTER TABLE `account`
  ADD CONSTRAINT `account_FK` FOREIGN KEY (`UserID`) REFERENCES `user` (`ID`);

--
-- Constraints der Tabelle `financetransaction`
--
ALTER TABLE `financetransaction`
  ADD CONSTRAINT `FK_FinanceTransaction_ShareValueId` FOREIGN KEY (`ShareValueId`) REFERENCES `sharevalue` (`ID`),
  ADD CONSTRAINT `FK_FinanceTransaction_UserId` FOREIGN KEY (`UserID`) REFERENCES `user` (`ID`);

--
-- Constraints der Tabelle `possession`
--
ALTER TABLE `possession`
  ADD CONSTRAINT `possession_ibfk_1` FOREIGN KEY (`SharesID`) REFERENCES `shares` (`ID`),
  ADD CONSTRAINT `possession_ibfk_2` FOREIGN KEY (`AccountID`) REFERENCES `account` (`ID`);

--
-- Constraints der Tabelle `sharevalue`
--
ALTER TABLE `sharevalue`
  ADD CONSTRAINT `shareValue_ibfk_1` FOREIGN KEY (`SharesID`) REFERENCES `shares` (`ID`);
--
-- Datenbank: `financeweb`
--
CREATE DATABASE IF NOT EXISTS `financeweb` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `financeweb`;
--
-- Datenbank: `test`
--
CREATE DATABASE IF NOT EXISTS `test` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `test`;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `tabelle1`
--

CREATE TABLE `tabelle1` (
  `ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `tabelle1`
--
ALTER TABLE `tabelle1`
  ADD PRIMARY KEY (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
