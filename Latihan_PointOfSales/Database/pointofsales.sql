-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 30 Des 2016 pada 15.55
-- Versi Server: 10.1.16-MariaDB
-- PHP Version: 5.6.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pointofsales`
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
(2, '69', 'mouse', 20, '50000.00', '75000.00', '2016-12-10 22:25:03', '2016-12-10 22:25:03'),
(3, '96', 'celana dalam', 8, '10000.00', '120000.00', '2016-12-10 23:21:57', '2016-12-10 23:21:57'),
(4, '007', 'monitor', 8, '20000.00', '40000.00', '2016-12-11 00:12:46', '2016-12-11 00:12:46'),
(5, '008', 'kaus kaki', 12, '50000.00', '80000.00', '2016-12-30 19:41:48', '2016-12-30 19:41:48');

-- --------------------------------------------------------

--
-- Struktur dari tabel `customer`
--

CREATE TABLE `customer` (
  `ID` int(11) NOT NULL,
  `Nama` varchar(100) NOT NULL,
  `Alamat` varchar(200) NOT NULL,
  `Zip_code` varchar(20) NOT NULL,
  `Phone_number` varchar(20) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `customer`
--

INSERT INTO `customer` (`ID`, `Nama`, `Alamat`, `Zip_code`, `Phone_number`, `Email`, `created_at`, `updated_at`) VALUES
(1, 'Miko', 'Jalan perdamaian', '6969', '083197489958', 'miko.keren@gmail.com', '2016-12-30 20:36:13', '2016-12-30 20:36:13'),
(2, 'fadly taris polem', 'Jalan ga pernah kerjain tugas', '7e70d965', '0813453499', 'fadly@gmail.com', '2016-12-30 20:33:30', '2016-12-30 20:33:30');

-- --------------------------------------------------------

--
-- Struktur dari tabel `pembelian`
--

CREATE TABLE `pembelian` (
  `id` int(11) NOT NULL,
  `kode` varchar(10) NOT NULL,
  `id_supplier` int(11) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `pembelian`
--

INSERT INTO `pembelian` (`id`, `kode`, `id_supplier`, `created_at`, `updated_at`) VALUES
(1, 'mikocerdas', 212, '2016-12-30 18:31:16', '2016-12-30 09:00:00');

-- --------------------------------------------------------

--
-- Struktur dari tabel `pembelian_detail`
--

CREATE TABLE `pembelian_detail` (
  `id` int(11) NOT NULL,
  `Id_pembelian` int(11) NOT NULL,
  `id_barang` int(11) NOT NULL,
  `harga_barang` decimal(11,0) NOT NULL,
  `kuantitas` int(11) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `penjualan`
--

CREATE TABLE `penjualan` (
  `id` int(11) NOT NULL,
  `kode` varchar(10) NOT NULL,
  `id_customer` int(11) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `penjualan_detail`
--

CREATE TABLE `penjualan_detail` (
  `id` int(11) NOT NULL,
  `id_penjualan` int(11) NOT NULL,
  `id_barang` int(11) NOT NULL,
  `harga_barang` decimal(10,2) NOT NULL,
  `kuantitas` int(11) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `supplier`
--

CREATE TABLE `supplier` (
  `ID` int(11) NOT NULL,
  `Nama` varchar(100) NOT NULL,
  `Alamat` varchar(200) NOT NULL,
  `Zip_code` varchar(20) NOT NULL,
  `Phone_Number` varchar(20) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `supplier`
--

INSERT INTO `supplier` (`ID`, `Nama`, `Alamat`, `Zip_code`, `Phone_Number`, `Email`, `created_at`, `updated_at`) VALUES
(1, 'Hanafi', 'Jalan Jemadi', '20239', '081288888888', 'hans@gmail.com', '2016-12-30 19:46:28', '2016-12-30 19:46:28');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `barang`
--
ALTER TABLE `barang`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `pembelian`
--
ALTER TABLE `pembelian`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `pembelian_detail`
--
ALTER TABLE `pembelian_detail`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `penjualan`
--
ALTER TABLE `penjualan`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `penjualan_detail`
--
ALTER TABLE `penjualan_detail`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `barang`
--
ALTER TABLE `barang`
  MODIFY `ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `pembelian`
--
ALTER TABLE `pembelian`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `pembelian_detail`
--
ALTER TABLE `pembelian_detail`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `penjualan`
--
ALTER TABLE `penjualan`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `penjualan_detail`
--
ALTER TABLE `penjualan_detail`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `supplier`
--
ALTER TABLE `supplier`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
