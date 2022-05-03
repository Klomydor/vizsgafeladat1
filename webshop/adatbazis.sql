-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2022. Ápr 28. 19:43
-- Kiszolgáló verziója: 10.4.22-MariaDB
-- PHP verzió: 8.1.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `raktar`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `elinditott`
--

CREATE TABLE `elinditott` (
  `id` int(11) NOT NULL,
  `szallitasid` int(11) NOT NULL,
  `futarid` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `futar`
--

CREATE TABLE `futar` (
  `id` int(11) NOT NULL,
  `futarnev` varchar(50) NOT NULL,
  `futarceg` int(11) DEFAULT NULL,
  `telefon` varchar(10) NOT NULL,
  `email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `futar`
--

INSERT INTO `futar` (`id`, `futarnev`, `futarceg`, `telefon`, `email`) VALUES
(1, 'Kiss Géza', 0, '+367037281', 'kiss.geza@foxpost.hu'),
(2, 'Németh Ilona', 2, '+363039992', 'Nemeth.Ilona@dpd.hu'),
(3, 'Tóth Imre', 1, '+362038227', 'Toth.Imre@gls.hu'),
(4, 'Németh Sándor', 1, '+363085547', 'Nemeth.sandor@gls.hu'),
(5, 'Kovács Ernő', 0, '+367088547', 'kovacs.erno@foxpost.hu'),
(6, 'Telkes Béla', 2, '+362056681', 'telkes.bela@dpd.hu'),
(7, 'Kiss Olga', 2, '+363056551', 'kiss.olga@dpd.hu');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `kategoria`
--

CREATE TABLE `kategoria` (
  `id` int(11) NOT NULL,
  `kategoria` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `kategoria`
--

INSERT INTO `kategoria` (`id`, `kategoria`) VALUES
(1, 'Kormány'),
(2, 'Fék'),
(3, 'Váltó'),
(4, 'Kerék'),
(5, 'Nyereg'),
(6, 'Hajtás'),
(7, 'MTB'),
(8, 'Trekking'),
(9, 'Országúti'),
(10, 'BMX'),
(11, 'Elektromos');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `rendeles`
--

CREATE TABLE `rendeles` (
  `id` int(11) NOT NULL,
  `darab` int(11) NOT NULL,
  `ar` int(11) NOT NULL,
  `termekid` int(11) DEFAULT NULL,
  `vevoid` int(11) DEFAULT NULL,
  `futarceg` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `szallitas`
--

CREATE TABLE `szallitas` (
  `id` int(11) NOT NULL,
  `vid` int(11) NOT NULL,
  `rid` int(11) NOT NULL,
  `tid` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `termek`
--

CREATE TABLE `termek` (
  `Id` int(11) NOT NULL,
  `cikkszam` varchar(6) NOT NULL,
  `kategoria` int(11) NOT NULL,
  `nev` varchar(40) NOT NULL,
  `darabar` int(11) NOT NULL,
  `darab` int(11) NOT NULL,
  `kep` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `vevo`
--

CREATE TABLE `vevo` (
  `id` int(11) NOT NULL,
  `Vevonev` varchar(50) NOT NULL,
  `adoszam` varchar(15) DEFAULT NULL,
  `irsz` int(11) NOT NULL,
  `helyseg` varchar(50) NOT NULL,
  `utca` varchar(50) NOT NULL,
  `hsz` int(11) NOT NULL,
  `telefon` varchar(12) DEFAULT NULL,
  `email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `elinditott`
--
ALTER TABLE `elinditott`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `elinditott` (`szallitasid`);

--
-- A tábla indexei `futar`
--
ALTER TABLE `futar`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `kategoria`
--
ALTER TABLE `kategoria`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `rendeles`
--
ALTER TABLE `rendeles`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `szallitas`
--
ALTER TABLE `szallitas`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `rendaz` (`rid`),
  ADD UNIQUE KEY `vevazaz` (`vid`);

--
-- A tábla indexei `termek`
--
ALTER TABLE `termek`
  ADD PRIMARY KEY (`Id`);

--
-- A tábla indexei `vevo`
--
ALTER TABLE `vevo`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `elinditott`
--
ALTER TABLE `elinditott`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT a táblához `futar`
--
ALTER TABLE `futar`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT a táblához `kategoria`
--
ALTER TABLE `kategoria`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT a táblához `rendeles`
--
ALTER TABLE `rendeles`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT a táblához `szallitas`
--
ALTER TABLE `szallitas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=126;

--
-- AUTO_INCREMENT a táblához `termek`
--
ALTER TABLE `termek`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=47;

--
-- AUTO_INCREMENT a táblához `vevo`
--
ALTER TABLE `vevo`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=42;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
