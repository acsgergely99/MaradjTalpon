-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2020. Jan 14. 12:25
-- Kiszolgáló verziója: 10.4.8-MariaDB
-- PHP verzió: 7.3.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `maradj_talpon`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `fo_jatekos`
--

CREATE TABLE `fo_jatekos` (
  `id` int(11) NOT NULL,
  `nev` varchar(30) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `lakhely` varchar(30) COLLATE utf8mb4_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `fo_jatekos`
--

INSERT INTO `fo_jatekos` (`id`, `nev`, `lakhely`) VALUES
(1, 'valami', 'valahol');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `jatekosok`
--

CREATE TABLE `jatekosok` (
  `id` int(11) NOT NULL,
  `nev` varchar(100) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `lakhely` varchar(50) COLLATE utf8mb4_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci COMMENT='A játékosok nevei';

--
-- A tábla adatainak kiíratása `jatekosok`
--

INSERT INTO `jatekosok` (`id`, `nev`, `lakhely`) VALUES
(1, 'Nagy Tamás', 'Budapest'),
(2, 'Takács Dorka', 'Budapest'),
(3, 'Kiss Péter', 'Pécs'),
(4, 'Németh Attila', 'Székesfehérvár'),
(5, 'Rózsavölgyi Virág', 'Sopron'),
(6, 'Kovács Bence', 'Hajdúszoboszló'),
(7, 'Kovacsevics László', 'Szeged'),
(8, 'Zoltán Péter', 'Budapest'),
(9, 'Elek Emese', 'Nyiregyháza'),
(10, 'Dávid Anna', 'Veszprém');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `kerdesek`
--

CREATE TABLE `kerdesek` (
  `id` int(11) NOT NULL,
  `feltett_kerdesek` varchar(100) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `voltE` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `kerdesek`
--

INSERT INTO `kerdesek` (`id`, `feltett_kerdesek`, `voltE`) VALUES
(1, 'Mikor volt az Aranybulla?', 0),
(2, 'Kinek az arcképe látható az 5000Ft-oson?', 0);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `fo_jatekos`
--
ALTER TABLE `fo_jatekos`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `jatekosok`
--
ALTER TABLE `jatekosok`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `kerdesek`
--
ALTER TABLE `kerdesek`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `fo_jatekos`
--
ALTER TABLE `fo_jatekos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT a táblához `jatekosok`
--
ALTER TABLE `jatekosok`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT a táblához `kerdesek`
--
ALTER TABLE `kerdesek`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
