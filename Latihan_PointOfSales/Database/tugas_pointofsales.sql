-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 10 Des 2016 pada 18.16
-- Versi Server: 10.1.16-MariaDB
-- PHP Version: 5.6.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tugas_pointofsales`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `barang`
--

CREATE TABLE `barang` (
  `ID` int(10) NOT NULL,
  `Kode` varchar(20) NOT NULL,
  `Nama` varchar(100) NOT NULL,
  `JumlahAwal` int(10) NOT NULL,
  `HargaHPP` decimal(16,2) NOT NULL,
  `HargaJual` decimal(16,2) NOT NULL,
  `created_At` datetime NOT NULL,
  `updated_At` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `barang`
--

INSERT INTO `barang` (`ID`, `Kode`, `Nama`, `JumlahAwal`, `HargaHPP`, `HargaJual`, `created_At`, `updated_At`) VALUES
(1, '44312', 'Buku Ipa', 50, '120000.00', '150000.00', '2016-12-10 22:24:16', '2016-12-10 22:24:16'),
(2, '22313', 'Harddisk External 1TB', 20, '750000.00', '800000.00', '2016-12-10 22:25:03', '2016-12-10 22:25:03'),
(3, '34098', 'Flashdisk 8GB', 35, '60000.00', '70000.00', '2016-12-10 23:21:57', '2016-12-10 23:21:57'),
(4, '34201', 'Headset Sony', 50, '350000.00', '460000.00', '2016-12-11 00:12:46', '2016-12-11 00:12:46');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `barang`
--
ALTER TABLE `barang`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `barang`
--
ALTER TABLE `barang`
  MODIFY `ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
