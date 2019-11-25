-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 05, 2019 at 04:56 AM
-- Server version: 10.1.36-MariaDB
-- PHP Version: 7.2.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `toko_kue`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_bahan_kue`
--

CREATE TABLE `tbl_bahan_kue` (
  `id_bahan` varchar(50) NOT NULL,
  `id_kue` varchar(50) NOT NULL,
  `ket_bahan` varchar(255) NOT NULL,
  `harga_bahan` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_detail_penjualan`
--

CREATE TABLE `tbl_detail_penjualan` (
  `id_transaksi` varchar(255) NOT NULL,
  `id_kue` varchar(50) NOT NULL,
  `kuantitas` int(11) NOT NULL,
  `harga_satuan` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_jenis_kue`
--

CREATE TABLE `tbl_jenis_kue` (
  `id_jenis` int(11) NOT NULL,
  `ket_kue` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_kue`
--

CREATE TABLE `tbl_kue` (
  `id_kue` varchar(50) NOT NULL,
  `nama_kue` varchar(255) NOT NULL,
  `id_jenis` int(11) NOT NULL,
  `gambar_kue` varchar(255) NOT NULL,
  `ukuran_kue` varchar(100) NOT NULL,
  `bentuk_kue` varchar(100) NOT NULL,
  `harga_kue` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_penjualan`
--

CREATE TABLE `tbl_penjualan` (
  `id_transaksi` varchar(255) NOT NULL,
  `tanggal_transaksi` date NOT NULL,
  `total_transaksi` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_user`
--

CREATE TABLE `tbl_user` (
  `id_user` int(11) NOT NULL,
  `username` varchar(150) NOT NULL,
  `password` varchar(255) NOT NULL,
  `level` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_bahan_kue`
--
ALTER TABLE `tbl_bahan_kue`
  ADD PRIMARY KEY (`id_bahan`);

--
-- Indexes for table `tbl_detail_penjualan`
--
ALTER TABLE `tbl_detail_penjualan`
  ADD PRIMARY KEY (`id_transaksi`,`id_kue`);

--
-- Indexes for table `tbl_jenis_kue`
--
ALTER TABLE `tbl_jenis_kue`
  ADD PRIMARY KEY (`id_jenis`);

--
-- Indexes for table `tbl_kue`
--
ALTER TABLE `tbl_kue`
  ADD PRIMARY KEY (`id_kue`);

--
-- Indexes for table `tbl_penjualan`
--
ALTER TABLE `tbl_penjualan`
  ADD PRIMARY KEY (`id_transaksi`);

--
-- Indexes for table `tbl_user`
--
ALTER TABLE `tbl_user`
  ADD PRIMARY KEY (`id_user`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
