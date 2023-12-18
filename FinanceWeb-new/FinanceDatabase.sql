-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 14. Dez 2023 um 12:38
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
(2, 10000, 14);

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
  `ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

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

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `shares`
--

CREATE TABLE `shares` (
  `ID` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

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
(14, 'Peter', 'Lustig', 'Peter4');

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
  ADD PRIMARY KEY (`ID`);

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
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT für Tabelle `apidetails`
--
ALTER TABLE `apidetails`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT für Tabelle `financetransaction`
--
ALTER TABLE `financetransaction`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT für Tabelle `possession`
--
ALTER TABLE `possession`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT für Tabelle `shares`
--
ALTER TABLE `shares`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT für Tabelle `sharevalue`
--
ALTER TABLE `sharevalue`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT für Tabelle `user`
--
ALTER TABLE `user`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `account`
--
ALTER TABLE `account`
  ADD CONSTRAINT `account_FK` FOREIGN KEY (`UserID`) REFERENCES `user` (`ID`);

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
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
