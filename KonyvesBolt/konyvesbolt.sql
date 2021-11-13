-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2021. Nov 13. 13:25
-- Kiszolgáló verziója: 10.4.19-MariaDB
-- PHP verzió: 7.3.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `konyvesbolt`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `irodalmikonyv`
--

CREATE TABLE `irodalmikonyv` (
  `Cim` varchar(128) NOT NULL,
  `Szerzo` varchar(128) NOT NULL,
  `OldalSzam` int(11) NOT NULL,
  `Ar` int(11) NOT NULL,
  `KiadasEv` int(11) NOT NULL,
  `Kategoria` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `irodalmikonyv`
--

INSERT INTO `irodalmikonyv` (`Cim`, `Szerzo`, `OldalSzam`, `Ar`, `KiadasEv`, `Kategoria`) VALUES
('Arany Ember', 'Jókai Mór', 234, 5600, 0, 'Egyéb'),
('Egri Csillagok', 'Gárdonyi Géza', 488, 7750, 0, 'Elbeszélés');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `tudomanyoskonyv`
--

CREATE TABLE `tudomanyoskonyv` (
  `Cim` varchar(128) NOT NULL,
  `Szerzo` varchar(128) NOT NULL,
  `OldalSzam` int(11) NOT NULL,
  `Ar` int(11) NOT NULL,
  `KiadasEv` int(11) NOT NULL,
  `TudomanyTerulet` varchar(128) NOT NULL,
  `ElismertKonyvE` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `tudomanyoskonyv`
--

INSERT INTO `tudomanyoskonyv` (`Cim`, `Szerzo`, `OldalSzam`, `Ar`, `KiadasEv`, `TudomanyTerulet`, `ElismertKonyvE`) VALUES
('Klíma', 'Charles Eisenstein', 345, 3500, 0, 'Biológia', 1),
('Mesterség és intelligencia', 'Tilesch György', 688, 5000, 0, 'Fizika', 1);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
